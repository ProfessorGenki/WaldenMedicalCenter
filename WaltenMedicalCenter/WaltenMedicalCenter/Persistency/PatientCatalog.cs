using System.Collections.Generic;
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

        public void CreatePatient(string name, string address, int ssn, int age)
        {
            Patient _p1 = new Patient(name, address, ssn, age);
            _pc.Add(_p1);
        }
    }
}