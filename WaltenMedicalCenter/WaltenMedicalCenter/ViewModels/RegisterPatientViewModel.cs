using System;
using Windows.UI.Xaml.Controls;
using WaltenMedicalCenter.Command;
using WaltenMedicalCenter.InsurancePlanService;
using WaltenMedicalCenter.Models;
using WaltenMedicalCenter.Persistency;

namespace WaltenMedicalCenter.ViewModels
{
    public class RegisterPatientViewModel : ViewModelBase
    {

        
        private InsurancePlanSystem _ips;
        private PatientCatalog _pc;
        private Relative _relative;
        private HospitalCard _hc;
        private int _ssn;
        private int _age;
        private string _provider;
        private string _validUntil;
        private string _pName;
        private string _address;
        private string _validTo;
        private string _rName;
        private string _rPhone;
        private string _relation;

        public Relative Relative
        {
            get { return _relative; }
            set
            {
                _relative = value;
                OnPropertyChanged("Relative");
            }
        }

        public HospitalCard HsCard
        {
            get { return _hc; }
            set
            {
                _hc = value;
                OnPropertyChanged("HsCard");
            }
        }

        public string Name
        {
            get
            {
                return _pName;
            }
            set
            {
                _pName = value;
                OnPropertyChanged("Name");
            }
        }

        public string ValidTo
        {
            get
            {
                return _validTo;
            }
            set
            {
                _validTo = value;
                OnPropertyChanged("ValidTo");
            }
        }

        public string RName
        {
            get
            {
                return _rName;
            }

            set
            {
                _rName = value;
                OnPropertyChanged("RName");
            }
        }

        public string RPhone
        {
            get
            {
                return _rPhone;
            }
            set
            {
                _rPhone = value;
                OnPropertyChanged("RPhone");
            }
        }

        public string Relationship
        {
            get
            {
                return _relation;
            }
            set
            {
                _relation = value;
                OnPropertyChanged("Relationship");
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        public int SSN
        {
            get { return _ssn; }
            set
            {
                _ssn = value;
                OnPropertyChanged("SSN");
            }
        }

        public string Provider
        {
            get { return _provider; }
            set
            {
                _provider = value;
                OnPropertyChanged("Provider");
            }
        }

        public string Plan { get; set; }

        public string ValidUntil
        {
            get { return _validUntil; }
            set
            {
                _validUntil = value;
                OnPropertyChanged("ValidUntil");
            }
        }

        public RelayCommand CheckInsurancePatientCommand { get; set; }
        public RelayCommand CheckPatientCommand { get; set; }
        public RelayCommand RegisterNewPatientCommand { get; set; }

        public RegisterPatientViewModel()
        {
            _ips = new InsurancePlanSystem();
            _pc = new PatientCatalog();
            CheckInsurancePatientCommand = new RelayCommand(CheckInsurance);
            RegisterNewPatientCommand = new RelayCommand(RegisterNewPatient);
            CheckPatientCommand = new RelayCommand(CheckPatient);

        }

        private void CheckInsurance()
        {
            InsurancePlan myIp = _ips.GetMember(SSN);
            Provider = myIp.Provider;
            Plan = myIp.Plan;
            ValidUntil = myIp.Validtil;
        }

        private void RegisterNewPatient()
        {
            if (Age < 18)
            {
                _pc.CreatePatientWithRelative(Name, HsCard, Relative, Address, SSN, Age, ValidTo, RName, RPhone, Relationship);
            }
            else
            {
                _pc.CreatePatient(HsCard, Name, Address, SSN, Age, ValidTo);
                
            }
        }

        private void CheckPatient()
        {
            Patient myPatient = _pc.GetMember(SSN);
            SSN = myPatient.PSSN;
            Name = myPatient.PName;
            Address = myPatient.PAddress;
            Age = myPatient.PAge;
            HsCard = myPatient.HC;
            Relative = myPatient.Rel;
            RName = myPatient.Rel.RName;
            RPhone = myPatient.Rel.RPhone;
            Relationship = myPatient.Rel.Relationship;
        }

    }
}