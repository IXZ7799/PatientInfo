using System;
using System.Collections.Generic;
using System.Text;

namespace PatientInfo
{
    public class PatientInformation
    {
        private string patientName;
        private DateTime dob;
        private string bmi;
        private string income;
        private bool gender;
        private string address;

        public string PatientName
        {
            get => patientName; set { patientName = value; }
        }

        public string BMI
        {
            get { return bmi; }
            set
            {
                if (bmi == "Normal" || bmi == "Underweight" || "Overweight")
                {
                    bmi = value;
                }
            }
        }

        public DateTime Dob { get => dob; set => dob = value; }
        public string Income { get => income; set => income = value; }
        public bool Gender { get => gender; set => gender = value }
        public string Address { get => address; set => address = value; }
    }
}