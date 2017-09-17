namespace WaltenMedicalCenter.Models
{
    public class Patient
    {
        #region Instance Fields

        private HospitalCard _hc;
        private Relative _rel;
        private string _pName;
        private string _pAddress;
        private int _pSsn;
        private int _pAge;

        #endregion

        #region Properties
        public HospitalCard HC
        {
            get { return _hc; }
            set { _hc = value; }
        }

        public Relative Rel
        {
            get { return _rel; }
            set { _rel = value; }
        }

        public string PName
        {
            get { return _pName; }
            set { _pName = value; }
        }

        public string PAddress
        {
            get
            {
                return _pAddress;
            }
            set
            {
                _pAddress = value;
            }
        }

        public int PSSN { get { return _pSsn; } set { _pSsn = value; } }
        public int PAge { get { return _pAge; } set { _pAge = value; } }
        #endregion

        #region Constructors

        public Patient(HospitalCard hc, string name, string address, int ssn, int age)
        {
            _pName = name;
            _pAddress = address;
            _pSsn = ssn;
            _pAge = age;
            _hc = hc;
        }

        public Patient(Relative rel, HospitalCard hc, string pName, string pAddress, int pSsn, int pAge)
        {
            _rel = rel;
            _hc = hc;
            _pName = pName;
            _pAddress = pAddress;
            _pSsn = pSsn;
            _pAge = pAge;
        }
        #endregion


    }
}