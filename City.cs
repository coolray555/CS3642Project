using System.Collections.Generic;
using System;

namespace CS3642Project{
    public class City {

        static int unused_id = 0;
        int id;
        float x = 0;
        float y = 0;
        List<int> distances;

        public List<int> Dists 
        {
            get { return distances;}

        }

        public City(float xPos, float yPos)
        {   
            this.id = unused_id;
            unused_id++;
            x = xPos;
            y = yPos;
        }

        public float calcDist(City other)
        {
            return Math.Sqrt(Math.Pow((other.x - this.x), 2) +  Math.Pow((other.y - this.y), 2 ) );
        }

    } 
}