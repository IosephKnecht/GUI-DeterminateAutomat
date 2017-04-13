using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Node : IEquatable<Node>
    {
        public string name { get; set; }
        public bool sost { get; set; }

        public Node(string name, bool sost)
        {
            this.name = name;
            this.sost = sost;
        }

        public bool Equals(Node other)
        {
            return this.name == other.name &&
                this.sost == other.sost;
        }
    }
}
