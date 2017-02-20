using System;
using System.Text;
using System.Security.Cryptography;

namespace HashEncryptorWinform
{
    class HashEncrypt
    {
        //field
        private string _msg; //msg needs to be stored in sha1 string
        private string _key; //key needs to be stored in sha1 string
        private string _resultHex; //in lowercase
        private string _resultBase64;

        //property
        public string Msg //msg needs to be stored in sha1 string
        {
            get { return _msg; }
            set { _msg = SHA1Store(value); }
        }

        public string Key //key needs to be stored in sha1 string
        {
            get { return _key; }
            set { _key = SHA1Store(value); }
        }

        public string ResultHex
        {
            get { return _resultHex; }
            set { _resultHex = value; }
        }

        public string ResultBase64
        {
            get
            {
                byte[] resultBuffer = Encoding.UTF8.GetBytes(this.ResultHex);
                _resultBase64 = Convert.ToBase64String(resultBuffer);
                return _resultBase64;
            }
        }

        //constructor
        public HashEncrypt(string msg, string key)
        {
            this.Msg = msg;
            this.Key = key;
        }

        //method
        public void RunEncrypt()
        {
            byte[] msgBuffer = Encoding.UTF8.GetBytes(this.Msg);
            byte[] keyBuffer = Encoding.UTF8.GetBytes(this.Key);
            HMACSHA1 hmacsha1 = new HMACSHA1(keyBuffer);
            byte[] resultBuffer = hmacsha1.ComputeHash(msgBuffer);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in resultBuffer)
            {
                sb.AppendFormat("{0:x2}", b);
            }
            this.ResultHex = sb.ToString();
        }

        /// <summary>
        /// raw_input should be stored in SHA1 string
        /// </summary>
        /// <param name="str">string raw_input</param>
        /// <returns>SHA1 string</returns>
        public string SHA1Store(string str)
        {
            byte[] strBuffer = Encoding.UTF8.GetBytes(str);
            HashAlgorithm sha1 = SHA1.Create();
            byte[] resultBuffer = sha1.ComputeHash(strBuffer);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in resultBuffer)
            {
                sb.AppendFormat("{0:x2}", b);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Password is a combination of 6 digits Hex cross adding 6digits Base64
        /// </summary>
        /// <returns>12 digits password</returns>
        public string GetPassword()
        {
            if (this.ResultHex == null)
            {
                this.RunEncrypt();
            }

            char[] hexChars = this.ResultHex.Substring(0, 6).ToCharArray();
            char[] base64Chars = this.ResultBase64.Substring(0, 6).ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                sb.Append(hexChars[i]);
                sb.Append(base64Chars[i]);
            }
            return sb.ToString();
        }
    }
}
