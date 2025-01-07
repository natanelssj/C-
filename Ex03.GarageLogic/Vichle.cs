using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C25_Ex03__Aviv_208667089_Natanel_314684697
{
    public abstract class Vichle
    {
        private string m_Model;
        public string m_LicensePlate;
        private float m_EnergyPrecents;




        public string LicensePlate
        {
            get { return m_LicensePlate; }
            set
            {
                if (CheckNumberOfLicense(value))
                {
                    m_LicensePlate = value;
                }
                else
                {
                throw new ArgumentException();
                }
            }


        }

        public float EnergyPrecents
        {
            get { return m_EnergyPrecents; }
            set { m_EnergyPrecents = value; }
        }

        public string Model
        {
            get { return m_Model; }
            set
            {
                m_Model = value;
            }   
        
        }





        private bool CheckNumberOfLicense(string m_licensePlate)
        {
            bool isNumberOfLicense = true;
            if (m_licensePlate.Length != 7)
            {
                isNumberOfLicense = false;
            }
            int checkNum;
            if (!(int.TryParse(m_licensePlate, out checkNum)))
            {
                isNumberOfLicense = false;
            }
            return isNumberOfLicense;
        }

    }
}
