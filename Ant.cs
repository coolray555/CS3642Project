using System.Collections.Generic;
using System.Linq;

namespace CS3642Project
{
    public class Ant
    {
        static Random rand = new Random();
        public List<City> VisitedCities = new List<City>();
        public List<City> UnvisitedCities = new List<City>();
        public int StartNodeID;
        public double Distance;
        public bool IsElite;
        public Cities world;
        public int Alpha;   //pheromone weight

        public Ant(int startNodeID, Cities cities, int alpha)
        {
            IsElite = rand.NextDouble() < .2;   //20 percent chance for elitist ant
            Alpha = IsElite ? alpha * 2 : alpha;   //if ant is elite double its pheromone impact
            this.world = cities;
            this.StartNodeID = startNodeID;
            this.Distance = 0;
            VisitedCities.Add(world.cities.Where(x => x.Id == startNodeId).First());
            UnvisitedCities = world.cities.Where(x => x.Id != startNodeId);
        }

        public City CurrentCity(){
            return VisitedCities[VisitedCities.Count - 1];
        }

        public void Move(){     //TODO 
            City curr = CurrentCity();
            if(UnvisitedCities.Count == 0){
                City next = VisitedCities[0];    //if there are no new cities then next city is where ant started
            }
            else{
                City next = ChooseNextCity();
                VisitedCities.Add(next);
                UnvisitedCities.Remove(next);
            }
            Edge currEdge = world.edges.First(x => x.StartID == curr.id && x.EndID == next.id);
            Distance += currEdge.Distance;
            DepositPheromone(curr);
        }

        private City ChooseNextCity(){  //will choose next city base on whether the city is in range. Elitist ants will more strongly favor cities that are closer.
            foreach(var city in UnvisitedCities){

            }
        }

        private void DepositPheromone(Edge edge){
            edge.pheromone = 1 / edge.Distance * Alpha;  //not sure if this is the approach we want to take
        }
    }
}