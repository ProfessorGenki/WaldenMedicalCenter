using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaltenMedicalCenter.InsurancePlanService
{
    public  class InsurancePlanSystem
    {
        public List<InsurancePlan> InsuranceSet { get; set; }
        public InsurancePlanSystem()
        {
            InsuranceSet = new List<InsurancePlan>();

            InsuranceSet.Add(new InsurancePlan() { SSN = 1, Provider = "AB", Plan = " Hospitalization", Validtil = "12-03-2018" });
            InsuranceSet.Add(new InsurancePlan() { SSN = 2, Provider = "CD", Plan = " kONSULTATION", Validtil = "1-06-2018" });
            InsuranceSet.Add(new InsurancePlan() { SSN = 3, Provider = "EF", Plan = " Hospitalization", Validtil = "02-03-2018" });
            InsuranceSet.Add(new InsurancePlan() { SSN = 4, Provider = "GH", Plan = " SCANNER", Validtil = "12-03-2019" });
            InsuranceSet.Add(new InsurancePlan() { SSN = 5, Provider = "IJ", Plan = " Blood test", Validtil = "12-12-2020" });
            InsuranceSet.Add(new InsurancePlan() { SSN = 6, Provider = "KL", Plan = " Hospitalization", Validtil = "12-03-2022" });
            InsuranceSet.Add(new InsurancePlan() { SSN = 7, Provider = "MN", Plan = " X-RAY", Validtil = "12-11-2018" });
            InsuranceSet.Add(new InsurancePlan() { SSN = 8, Provider = "OP", Plan = " Hospitalization", Validtil = "12-03-2018" });
            InsuranceSet.Add(new InsurancePlan() { SSN = 9, Provider = "QR", Plan = " Medical treatment", Validtil = "2-03-2018" });
            InsuranceSet.Add(new InsurancePlan() { SSN = 10, Provider = "ST", Plan = " Hospitalization", Validtil = "11-03-2018" });
        }

        public List<InsurancePlan> GetAllPlans()
        {
            return InsuranceSet;
        }

        public InsurancePlan GetMember(int ssn)
        {
            InsurancePlan ip = null;
            if (InsuranceSet != null)
                foreach (var ip1 in InsuranceSet)
                {
                    if (ip1.SSN == ssn)
                    {
                        ip = ip1;
                    }
                }
            return ip;

        }

    }
}
