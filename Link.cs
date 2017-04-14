using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Link:IEquatable<Link>
    {
        public Node start_node { get; set; }
        public string transition { get; set; }
        public Node final_node { get; set; }

        public Link() { }

        public Link(Node start_node, string transition, Node final_node)
        {
            this.start_node = start_node;
            this.transition = transition;
            this.final_node = final_node;
        }

        public bool Equals(Link other)
        {
                    return this.start_node.name == other.start_node.name &&
                        this.start_node.sost == other.start_node.sost &&
                        this.transition == other.transition &&
                        this.final_node.name == other.final_node.name &&
                        this.final_node.sost == other.final_node.sost;
        }


    }
}
