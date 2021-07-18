using System.Collections.Generic;
using System.Linq;

namespace CS3642Project
{
    public class Ant
    {
        static Random rand = new Random();
        public List<City> VisitedNodes;
        public List<City> UnvisitedNodes;
        public int StartNodeID;
        public int CurrentNodeID;
        public double Distance;
        public bool IsElite;
        public Cities world;
        public int Beta;

        public Ant(int startNodeID, Cities cities, int Beta)
        {
            IsElite = rand.NextDouble() < .2;   //20 percent chance for elitist ant
            this.world = cities;
            this.StartNodeID = startNodeID;
            this.Distance = 0;
            VisitedNodes.Add(world.cities.Where(x => x.Id == startNodeId).First());
            UnvisitedNodes = world.cities.Where(x => x.Id != startNodeId);
        }
        public bool CanMove(){
            return VisitedNodes.Count == world?.cities.Count;
        }

        public City CurrentCity(){
            return VisitedNodes[VisitedNodes.Count - 1];
        }

        public void Move(){     //TODO 
            if(CanMove()){
                City next = ChooseNextCity();
                Distance += CurrentCity().calcDist(next);
                VisitedNodes.Add(next);
                UnvisitedNodes.Remove(next);
            }
        }

        private City ChooseNextCity(){  //will choose next city base on whether the city is in range. Elitist ants will more strongly favor cities that are closer.
            foreach(var city in UnvisitedNodes){

            }
        }
    }
}