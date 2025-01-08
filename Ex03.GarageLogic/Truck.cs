using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C25_Ex03__Aviv_208667089_Natanel_314684697;

namespace Ex03.GarageLogic
{
    internal class Truck
    {
        bool m_isTransportRefrigeratedMaterials;
        float m_CargoVolume;
        Wheel m_Wheel=new Wheel;
        m_Wheel=14;
        int m_AirPressure = 29;
        string m_Fuel = "Soler";
        float m_TankFuel = 125;
        public bool IsTransportRefrigeratedMaterials 
        {
            get { return m_isTransportRefrigeratedMaterials; }
            set { m_isTransportRefrigeratedMaterials = value; }
        }

        public float CargoVolume 
        {
            get { return m_CargoVolume; }
            set
            {
                m_CargoVolume = value;
            }

        }

    }
}
 