using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    internal class Motorcycle:Dr
    {
        int const m_Wheels = 2;

        string[] m_LicenseType = {"A1","A2","B1","B2"};
        
        int EngineDisplacementCc = 0;

        int m_AirPressure = 32;

        float m_FuelTank = 6.2;


        string m_Fuel = "Octan98";
    }
}
