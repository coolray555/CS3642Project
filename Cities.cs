using System.Collections.Generic;
using System;

namespace CS3642Project
{

    public class Cities   //to remove redundant names this could be called world or country 
    {   
        static Random rand = new Random();
        List<City> cities;
        List<Edge> edges; 

        public Cities(int count)
        {   
            //generate cities
            for (int i = 0; i < count; i++)
            {
                float x = (float)rand.Next(count * 2);
                float y = (float)rand.Next(count * 2);
                cities.Add(new City(x,y));
            }

            //calculate distances
            //initialize edges
            //possibly store them in
            for (int i = 0; i < cities.Count; i++)
            {
                for (int j = 0; j < cities.Count; j++)
                {
                    float cur_dist = cities[i].calcDist(cities[j]);
                    edges.Add(new Edge(cities[i].Id, cities[j].Id, cur_dist));
                }
            }


        }
        
        

        public List<City> getCitiesInRange(City start, int range)  //in case we want some ants to only consider a certain distance
        {   
            List<City> inRange;
            foreach(City c in cities)
            {
                if (start.Dists[c.id] <= range)
                {
                    inRange.Add(c);
                }
            }

            return inRange;
        }
    }

}