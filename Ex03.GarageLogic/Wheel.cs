using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C25_Ex03__Aviv_208667089_Natanel_314684697
{
    internal class Wheel
    {
        private string m_ManufacturerName;
        internal float m_CurrentAirPressure;
        private float m_MaxAirPressure;

        
        string ManufacturerName 
        {
            get { return m_ManufacturerName; }
            set
            {
                m_ManufacturerName = value;
            }
        }
        internal float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
            set
            {
                if (value <= m_MaxAirPressure && value >= 0)
                {
                    m_CurrentAirPressure = value;
                }
                else 
                {
                    throw new Exception();
                }
            }
        }        
        internal float MaxAirPressure
        {
            get { return m_MaxAirPressure; }
            set
            {
                m_MaxAirPressure = value;
            }
        }

        void AddAir(float CurrentAir, float MaxAir,float AddAirWheel)
        {
            if (CurrentAir+AddAirWheel<=MaxAir)
            {
                CurrentAir +=AddAirWheel ;
            }
        }
    }
}
