namespace WaltenMedicalCenter.Models
{
    public class Relative
    {
        #region Instance Fields

        private string _rName;
        private string _rPhone;
        private string _relationship;

        #endregion


        public Relative(string rName, string rPhone, string relationship)
        {
            _rName = rName;
            _rPhone = rPhone;
            _relationship = relationship;
        }
    }
}