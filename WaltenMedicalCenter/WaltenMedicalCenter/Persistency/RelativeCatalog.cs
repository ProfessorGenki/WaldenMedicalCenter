using System.Collections.Generic;
using WaltenMedicalCenter.Models;

namespace WaltenMedicalCenter.Persistency
{
    public class RelativeCatalog
    {
        private List<Relative> _rc;
        public RelativeCatalog()
        {
            _rc = new List<Relative>();
        }



        public void CreateRelative(string name, string phone, string relation)
        {
            Relative _related = new Relative(name, phone, relation);
            _rc.Add(_related);
        }

        public Relative GetMember(string phone)
        {
            Relative p = null;
            if (_rc != null)
                foreach (Relative p1 in _rc)
                {
                    if (p1.RPhone == phone)
                    {
                        p = p1;
                    }
                }
            return p;
        }
    }
}