using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Star_Path_Finding_Implementation
{
    class FrontierQueue
    {
        Dictionary<Node,int> queue;
       
        public void put(Node n, int priority)
        {
            if (!ContainsKey(n))
                queue.Add(n, priority);
        }
        
        public bool isEmpty()
        {
            if (queue.Count == 0)
                return true;
            else return false;
        }
        
        public Node get()
        {
            int minVal = queue.Values.Min();
            Node n  = queue.FirstOrDefault(x => x.Value == minVal).Key ;
            queue.Remove(n);
            return n;
        }
        public FrontierQueue()
        {
            this.queue = new Dictionary<Node, int>();
        }
        private bool ContainsKey(Node n)
        {
            foreach (Node node in queue.Keys)
            {
                if (n.ID == node.ID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
