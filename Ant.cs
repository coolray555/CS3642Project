using System.Collections.Generic;
using System.Linq;

namespace CS3642Project
{
    public class Ant
    {
        public List<City> VisitedNodes;
        public List<City> UnvisitedNodes;
        public int StartNodeID;
        public double Distance;

        public Ant(int startNodeID, List<City> Cities)
        {
            StartNodeID = startNodeID;
            Distance = 0;
            VisitedNodes.Add(Cities.Where(x => x.Id == startNodeId).First());
            UnvisitedNodes = Cities.Where(x => x.Id != startNodeId);
        }
    }
}