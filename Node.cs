using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Star_Path_Finding_Implementation
{
    public class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        private string id;
        public Node parentNode { get; set; }

        public string ID
        {
            get {
                id = X + " : " + Y;
                return id; }
        private    set { id = value; }
        }
        public List<Node> Neighbors { get; set; }

        public Node()
        {
            Neighbors = new List<Node>();
        }
        public Node(int x, int y)
        {
            Neighbors = new List<Node>();
            this.X = x;
            this.Y = y;
        }
    }
}
