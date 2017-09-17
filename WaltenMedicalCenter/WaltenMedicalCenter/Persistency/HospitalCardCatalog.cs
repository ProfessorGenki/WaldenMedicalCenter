using System.Collections.Generic;
using WaltenMedicalCenter.Models;

namespace WaltenMedicalCenter.Persistency
{
    public class HospitalCardCatalog
    {
        private List<HospitalCard> _hcc;
        public HospitalCardCatalog()
        {
            _hcc = new List<HospitalCard>();
        }

        public void CreateHospitalCard(int cardId, string validTo)
        {
            HospitalCard _hospitalCard = new HospitalCard(cardId, validTo);
            _hcc.Add(_hospitalCard);
        }
        public HospitalCard GetMember(int ssn)
        {
            HospitalCard p = null;
            if (_hcc != null)
                foreach (HospitalCard p1 in _hcc)
                {
                    if (p1.CardId == ssn)
                    {
                        p = p1;
                    }
                }
            return p;
        }
    }
}