namespace WaltenMedicalCenter.Models
{
    public class HospitalCard
    {
        #region Instance Fields

        private int _cardId;
        private string _validTo;

        #endregion

        #region Properties

        public int CardId
        {
            get { return _cardId; }
            set { _cardId = value; }
        }

        public string ValidTo
        {
            get { return _validTo; }
            set { _validTo = value; }
        }

        #endregion

        #region Constructors

        public HospitalCard(int cardId, string validTo)
        {
            _cardId = cardId;
            _validTo = validTo;
        }

        #endregion
    }
}