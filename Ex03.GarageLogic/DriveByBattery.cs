using System;
namespace Ex03.GarageLogic
{

    public class DriveByBattery
    {
        public float m_TimeRemain =0;
        float m_MaxTime=0
        public DriveByBattery()
        {
            
        }

        public void Charge (float timeAddCharge )
        {
            if (timeAddCharge + m_TimeRemain <= m_TimeRemain)
            {
                m_TimeRemain += timeAddCharge;
            }
        }
    }
}

