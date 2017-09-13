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
        public HospitalCard HC { get; set; }
        public Relative Rel { get; set; }

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
        public int PAge { get { return _pAge;  } set { _pAge = value; } }
        #endregion

        #region Constructors

        public Patient(string name, string address, int ssn, int age)
        {
            _pName = name;
            _pAddress = address;
            _pSsn = ssn;
            _pAge = age;
        }

        public Patient(HospitalCard hc, Relative rel, string pName, string pAddress, int pSsn, int pAge)
        {
            _hc = hc;
            _rel = rel;
            _pName = pName;
            _pAddress = pAddress;
            _pSsn = pSsn;
            _pAge = pAge;
        }
        #endregion


    }
}