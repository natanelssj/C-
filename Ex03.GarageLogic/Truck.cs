using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Truck
    {
        bool m_isTransportRefrigeratedMaterials;
        float m_CargoVolume;

        
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
 