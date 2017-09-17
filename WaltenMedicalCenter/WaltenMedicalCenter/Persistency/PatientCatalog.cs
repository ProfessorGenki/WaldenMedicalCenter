using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using WaltenMedicalCenter.Models;

namespace WaltenMedicalCenter.Persistency
{
    public class PatientCatalog
    {
        private List<Patient> _pc; // The List
        private RelativeCatalog _rc;
        private HospitalCardCatalog _hcc;

        // need for constructor to construct objects
        public PatientCatalog()
        {
            _pc = new List<Patient>();
            _rc = new RelativeCatalog();
            _hcc = new HospitalCardCatalog();
        }

        public void CreatePatient(HospitalCard hc, string name, string address, int ssn, int age, string validTo)
        {
            _hcc.CreateHospitalCard(ssn,validTo);
            hc = _hcc.GetMember(ssn);
            Patient _p1 = new Patient(hc,name, address, ssn, age);
            _pc.Add(_p1);
        }

        public void CreatePatientWithRelative(string name, HospitalCard hc, Relative rel, string address, int ssn, int age, string validTo, string rName, string rPhone, string rRelation)
        {
            _hcc.CreateHospitalCard(ssn, validTo);
            hc = _hcc.GetMember(ssn);
            _rc.CreateRelative(rName, rPhone, rRelation);
            rel = _rc.GetMember(rPhone);

            Patient _p1 = new Patient(rel, hc, name, address, ssn, age);

            _pc.Add(_p1);
            

        }

        public Patient GetMember(int ssn)
        {
            Patient p = null;
            if (_pc != null)
                foreach (Patient p1 in _pc)
                {
                    if (p1.PSSN == ssn)
                    {
                        p = p1;
                    }
                }
            return p;
        }
    }

}