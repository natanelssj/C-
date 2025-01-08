using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C25_Ex03__Aviv_208667089_Natanel_314684697;

namespace Ex03.GarageLogic
{
    enum CarColor
    {
        White= 1,
        Blue ,
        Black,
        Gray
    }
    class PrivateCar: DriveByFuel()
    {
        string[] m_Color = {"blue", "black","white","gray" };
        CarColor m_CarColor=CarColor.White;
        int[] m_DoorsNumber = { 2, 3, 4, 5 };

        
        int const m_Wheels = 5;

        string[] m_LicenseType = { "A1", "A2", "B1", "B2" };

        int EngineDisplacementCc = 0;

        int m_AirPressure = 34;

        float m_FuelTank = 52;

        string m_Fuel = "Octan95";

    }
}
