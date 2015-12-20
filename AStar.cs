using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Star_Path_Finding_Implementation
{
    public class AStar
    {

        FrontierQueue frontier = new FrontierQueue();
        Dictionary<Node, Node> cameFrom = new Dictionary<Node, Node>();
        Dictionary<Node, int> cost_so_far = new Dictionary<Node, int>();
        Node current;
        public List<Node> Search(Node start, Node goal)
        {

            frontier.put(start, 0);
            cameFrom[start] = null;
            cost_so_far[start] = 0;

            while (frontier.isEmpty() == false)
            {
                current = frontier.get();

                if (current.ID == goal.ID)
                {
                    //best path founded, break searching
                    break;
                }

                foreach (Node next in current.Neighbors)
                {
                    if (!next.isWall)
                    {
                        var new_cost = cost_so_far[current] + 1;
                        if (inCostSoFar(next) == false || new_cost < cost_so_far[next])
                        {
                            cost_so_far[next] = new_cost;
                            var priority = new_cost + heuristic(goal, next);
                            frontier.put(next, priority);
                            cameFrom[next] = current;
                        }
                    }
                   
                }
            }

            return reconstruct_path(cameFrom, current);
        }
        
        public List<Node> reconstruct_path(Dictionary<Node, Node> cameFrom, Node current)
        {
            List<Node> totalPath = new List<Node>();
            totalPath.Add(current);
            while (current != null && inCameFrom(current) == true  )
            {
                current = cameFrom[current];
                totalPath.Add(current);
            }

            return totalPath;
        }
        //this method looks CameFrom  to find current like contains() method (Contains did not work)
        private bool inCameFrom(Node current)
        {
            foreach (var n in cameFrom.Keys)
            {
                if (n.ID == current.ID)
                {
                    return true;
                }
            }
            return false;
        }
        private bool inCostSoFar(Node next)
        {
            foreach (var n in cost_so_far.Keys)
            {
                if (next.ID == n.ID)
                {
                    return true;
                }
            }
            return false;
        }
        //We used Manhattan distance for calculating heuristic distance.
        private int heuristic(Node a, Node b)
        {
            return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
        }
    }
}
