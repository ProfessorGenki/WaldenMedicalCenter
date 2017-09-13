using System;
using WaltenMedicalCenter.Command;
using WaltenMedicalCenter.InsurancePlanService;
using WaltenMedicalCenter.Persistency;

namespace WaltenMedicalCenter.ViewModels
{
    public class RegisterPatientViewModel : ViewModelBase
    {


        private InsurancePlanSystem _ips;
        private PatientCatalog _pc;
        private int _ssn;
        private int _age;
        private string _provider;
        private string _validUntil;
        private string _name;
        private string _address;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
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

        public RelayCommand RegisterNewPatientCommand { get; set; }

        public RegisterPatientViewModel()
        {
            _ips = new InsurancePlanSystem();
            _pc = new PatientCatalog();
            CheckInsurancePatientCommand = new RelayCommand(CheckInsurance);
            RegisterNewPatientCommand = new RelayCommand(RegisterNewPatient);

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

            _pc.CreatePatient(Name, Address, SSN, Age);
        }

    }
}