using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PasswordHasher
{
    public class HashViewModel : ViewModelBase
    {
        #region Commands
        public ICommand GenerateHashCommand
        {
            get
            {
                if (generateHashCommand == null)
                {
                    generateHashCommand = new DelegateCommand(GenerateHash, CanGenerateHash);
                }
                return generateHashCommand;
            }
        }
        public ICommand ClearTextBoxCommand
        {
            get
            {
                if (clearTextBoxCommand == null)
                {
                    clearTextBoxCommand = new DelegateCommand(ClearTextBox);
                }
                return clearTextBoxCommand;
            }
        }
        #endregion // Commands

        #region Private Members
        private HashModel hashingModel;
        private DelegateCommand generateHashCommand;
        private DelegateCommand clearTextBoxCommand;
        private string applicationTitle;
        private string generatedHash;
        #endregion // Private Members

        #region Public Fields
        public string ApplicationTitle
        {
            get { return applicationTitle; }
        }
        public string OriginalPassword
        {
            get { return hashingModel.OrignalPassword; }
            set { hashingModel.OrignalPassword = value; }
        }
        public string Salt
        {
            get { return hashingModel.Salt; }
            set { hashingModel.Salt = value; }
        }
        public string Result
        {
            get { return hashingModel.HashedPassword; }
        }
        public string GeneratedHash
        {
            get { return generatedHash; }
            set
            {
                generatedHash = value;
                OnPropertyChanged("GeneratedHash");
            }
        }
        #endregion // Public Fields

        #region Constructor
        public HashViewModel()
        {
            hashingModel = new HashModel();
            applicationTitle = hashingModel.WindowTitle;
            OriginalPassword = string.Empty;
            Salt = string.Empty;
            generatedHash = string.Empty;
        }
        #endregion // Constructor

        #region Private Methods
        private void ClearTextBox()
        {
            OriginalPassword = string.Empty;
            OnPropertyChanged("OriginalPassword");
            Salt = string.Empty;
            OnPropertyChanged("Salt");
            GeneratedHash = string.Empty;
        }
        private bool CanGenerateHash()
        {
            if (!string.IsNullOrEmpty(this.OriginalPassword) && !string.IsNullOrEmpty(this.Salt)) return true;
            else return false;
        }

        private void GenerateHash()
        {
            hashingModel.GeneratingResult();
            GeneratedHash = Result;
        }
        #endregion // Private Methods
    }
}
