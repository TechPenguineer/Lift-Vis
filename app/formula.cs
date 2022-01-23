using System;
using System.Collections.Generic;
using System.Text;

namespace app
{
    class formula
    {
        public float coeficcent_of_lift;                 // AoA 
        public float air_desnity;                        // Air Density
        public int airspeed;                             // Airspeed
        public float wing_surface_area;                  // Wing Surface Area

        public float calculate_lift(float col, float ad, int ias, float wsa) // AoA, AirDensity, AirSpeed, WingSurfaceArea
        {

            float lift_pt1 = coeficcent_of_lift / 2 * air_desnity;
            float lift_pt2 = airspeed << 2;
            float lift = lift_pt1 * lift_pt2 * wing_surface_area;

            return lift;
        }
    }
}
