using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHasher
{
    public class HashModel
    {
        #region Private Members
        private string windowTitle = "Password Hasher";
        private string hashedPasswordResult;
        #endregion // Private Members

        #region Public Fields
        public string WindowTitle { get { return windowTitle; } }
        public string HashedPassword { get { return hashedPasswordResult; } }
        public string OrignalPassword { get; set; }
        public string Salt { get; set; }
        #endregion // Public Fields

        #region ctor
        public HashModel(string _OrignalPassword, string _salt)
        {
            OrignalPassword = _OrignalPassword;
            Salt = _salt;
            hashedPasswordResult = string.Empty;
        }
        public HashModel()
        {
            OrignalPassword = string.Empty;
            Salt = string.Empty;
            hashedPasswordResult = string.Empty;
        }
        #endregion

        #region Helper Methods
        public void GeneratingResult()
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] textWithSaltBytes = utf8.GetBytes(string.Concat(OrignalPassword, Salt));
            HashAlgorithm hasher = new SHA1CryptoServiceProvider();
            byte[] hashedBytes = hasher.ComputeHash(textWithSaltBytes);
            hasher.Clear();
            hashedPasswordResult = Convert.ToBase64String(hashedBytes);
        }
        #endregion Helper Methods
    }
}
