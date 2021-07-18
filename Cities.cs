using System.Collections.Generic;
using System;

namespace CS3642Project
{

    public class Cities   //to remove redundant names this could be called world or country 
    {   
        static Random rand = new Random();
        List<City> cities;

        public Cities(int count)
        {
            for (int i = 0; i < count; i++)
            {
                float x = (float)rand.Next(count * 2);
                float y = (float)rand.Next(count * 2);
                cities.Add(new City(x,y));
            }

            for (int i = 0; i < cities.Count; i++)
            {
                for (int j = 0; j < cities.Count; j++)
                {
                    List<int> dist_list = cities[i].Dists;
                    float cur_dist = cities[i].calcDist(cities[j]);
                    dist_list.Add(cur_dist);
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