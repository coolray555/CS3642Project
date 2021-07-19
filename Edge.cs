using System.Collections.Generic;
using System.Linq;

namespace CS3642Project
{
    public class Edge{
        public int StartID;
        public int EndID;
        public float Distance;
        public double pheromone;

        public Edge(int start, int end, float distance){
            StartID = start;
            EndID = end;
            Distance = distance;
        }
    }
}