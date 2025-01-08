using System;
namespace Ex03.GarageLogic
{
    public class DriveByFuel
    {
        public enum Fuel
        {
            Octan95,
            Octan96,
            Octan98,
            Soler
        }
        float m_FuelRemain = 0;
        float m_FuelMax = 0;

        public DriveByFuel()
        {
        }
        public void Fuel(float addToTank)
        {
            if (addToTank + m_FuelRemain <= m_FuelMax)
            {
                m_FuelRemain += addToTank;
            }
            else { 
            }
        }
    }

}
