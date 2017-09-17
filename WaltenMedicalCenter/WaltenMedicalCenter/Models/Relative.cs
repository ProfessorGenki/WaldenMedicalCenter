namespace WaltenMedicalCenter.Models
{
    public class Relative
    {
        #region Instance Fields

        private string _rName;
        private string _rPhone;
        private string _relationship;

        #endregion

        public string RName { get { return _rName; } set { _rName = value; } }
        public string RPhone { get { return _rPhone; } set { _rPhone = value; } }
        public string Relationship { get { return _relationship; } set { _relationship = value; } }


        public Relative(string rName, string rPhone, string relationship)
        {
            _rName = rName;
            _rPhone = rPhone;
            _relationship = relationship;
        }
    }
}