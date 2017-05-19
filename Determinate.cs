using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Determinate
    {
        private List<Link> global_links;
        private List<string> transitions;
        private List<Node> new_final_nodes = new List<Node>();
        private List<Node> primitive_node;
        private string current_start_node;

        public Determinate(List<Link> links,List<string> transitions,List<Node> primitive_node, string current_start_node)
        {
            this.global_links = links;
            this.transitions = transitions;
            this.primitive_node = primitive_node;
            this.current_start_node = current_start_node;
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
            foreach (Link start_link in global_links)
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

        private bool Sost_new_node(string new_name)
        {
            bool sost = false;
            foreach (char sym in new_name)
            {
                foreach (Node node in primitive_node)
                {
                    if (sym.ToString() == node.name)
                        if (node.sost == true) return true;
                }
            }
            return sost;
        }

        private Link Calcul_new_link(Link old_link)
        {
            string new_final = null;

            foreach (char node in old_link.final_node.name)
            {
                Link test_link = Search_start_link(node.ToString(), old_link.transition);
                if (!null_link(test_link))
                {
                    new_final += test_link.final_node.name;
                }
            }

            if (new_final != null)
            {
                new_final = new string(new_final.Distinct().ToArray());
                new_final = new string(new_final.OrderBy(key => key).ToArray());

                Node new_final_node = new Node(new_final, Sost_new_node(new_final));
                if(!new_final_nodes.Contains(new_final_node)) new_final_nodes.Add(new_final_node);

                return new Link(old_link.final_node, old_link.transition, new_final_node);
            }
            else return new Link();
        }

        private void DeleteNanNodes(List<Link> links)
        {
            //for (int i = 0; i < links.Count; i++)
            //{
            //    Link link = links[i];
            //    if (!new_final_nodes.Contains(link.final_node)&&!new_final_nodes.Contains(link.start_node))
            //    {
            //        links.RemoveAt(i);
            //        i = 0;
            //    }
            //}
            for (int i = 0; i < links.Count; i++)
            {
                bool NanNode = true;
                for (int j = 0; j < links.Count; j++)
                {
                    if(!links[j].start_node.Equals(links[j].final_node))
                    {
                        if(links[i].start_node.name == current_start_node)
                        {
                            NanNode = false;
                            break;
                        }
                        if (links[i].start_node.Equals(links[j].final_node))
                        {
                            NanNode = false;
                            break;
                        }
                    }
                }
                if (NanNode)
                {
                    links.RemoveAt(i);
                    i = -1;
                }
            }
            string s = null;
        }

        public List<Link> Det()
        {
            var cash = new List<Link>();
            foreach (Link link in global_links)
            {
                Node start_node = new Node(link.start_node.name, link.start_node.sost);
                Node final_node = new Node(link.final_node.name, link.final_node.sost);
                cash.Add(new Link(start_node, link.transition, final_node));
            }
            var links = Links_to_determinate(cash);
            if (this.global_links == links) return this.global_links;
            global_links = cash;
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
