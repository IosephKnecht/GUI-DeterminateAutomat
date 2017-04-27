using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Determinate
    {
        private List<Link> links;
        private List<string> transitions;
        private List<Node> new_final_nodes = new List<Node>();

        public Determinate(List<Link> links,List<string> transitions)
        {
            this.links = links;
            this.transitions = transitions;
            //Links_to_determinate();
        }

        private List<Link> Links_to_determinate(List<Link> links)
        {
            for (int i = 0; i < links.Count; i++)
            {
                for (int j = 0; j < links.Count; j++)
                {
                    if (i != j)
                    {
                        if (links[i].start_node.name == links[j].start_node.name &&
                            links[i].transition == links[j].transition)
                        {
                            if (links[i].final_node.name == links[j].final_node.name) links.RemoveAt(j);
                            else
                            {
                                string new_name = new string((links[i].final_node.name + links[j].final_node.name).Distinct().ToArray());
                                new_name = new string(new_name.OrderBy(key => key).ToArray());
                                links[i].final_node.name = new_name;
                                if (links[i].final_node.sost || links[j].final_node.sost) links[i].final_node.sost = true;
                                links.RemoveAt(j);
                            }
                        }
                    }
                }
            }
            return links;
        }

        private Link Search_start_link(string name, string trans)
        {
            foreach (Link start_link in links)
            {
                if (start_link.start_node.name == name
                    && start_link.transition == trans)
                    return start_link;
            }
            return new Link();
        }

        private bool null_link(Link link)
        {
            if (link.start_node == null && link.transition == null && link.final_node == null)
                return true;
            else
                return false;
        }

        private Link Calcul_new_link(Link old_link)
        {
            string new_final = null;
            bool sost = false ;

            foreach (char node in old_link.final_node.name)
            {
                Link test_link = Search_start_link(node.ToString(), old_link.transition);
                if (!null_link(test_link))
                {
                    new_final += test_link.final_node.name;
                    if (test_link.start_node.sost||test_link.final_node.sost) sost = true;
                }
            }

            if (new_final != null)
            {
                new_final = new string(new_final.Distinct().ToArray());
                new_final = new string(new_final.OrderBy(key => key).ToArray());

                Node new_final_node = new Node(new_final, sost);
                if(!new_final_nodes.Contains(new_final_node)) new_final_nodes.Add(new_final_node);

                return new Link(old_link.final_node, old_link.transition, new_final_node);
            }
            else return new Link();
        }

        private void DeleteNanNodes(List<Link> links)
        {
            for (int i = 0; i < links.Count; i++)
            {
                Link link = links[i];
                if (!new_final_nodes.Contains(link.final_node)&&!new_final_nodes.Contains(link.start_node))
                {
                    links.RemoveAt(i);
                    i = 0;
                }
            }
        }

        public List<Link> Det()
        {
            var links = Links_to_determinate(new List<Link>(this.links));
            if (this.links == links) return this.links;
            for (int i = 0; i < links.Count; i++)
            {
                Node node = links[i].final_node;
                if (node.name.Length > 1)
                {
                    foreach (string s in transitions)
                    {
                        Link test_link = new Link(new Node(links[i].start_node.name,links[i].start_node.sost),
                            s, new Node(links[i].final_node.name, links[i].final_node.sost));
                        Link new_link = Calcul_new_link(test_link);
                        if(!null_link(new_link))
                            if(!links.Contains(new_link)) links.Add(new_link);
                        string n = string.Empty;
                    }
                    //string n = string.Empty;
                    //transition_matrix.Add(new Node(node.final_node, node.transition, NewNode(node)));
                }
            }
            DeleteNanNodes(links);
            //links.AddRange(new_links);
            return links;
            //Return_transition_matrix(transition_matrix);
        }
    }
}
