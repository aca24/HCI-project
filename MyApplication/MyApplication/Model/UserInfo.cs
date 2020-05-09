using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Windows;

namespace MyApplication.Model
{
    public class UserInfo
    {
        private String filePath;

        public UserInfo()
        {
            /*
            String workingDirectory = Environment.CurrentDirectory;
            String projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            String[] path = { projectDirectory, "Resources", "userinfo.log" };
            */
            filePath = "../../Resources/userinfo.log";
        }

        public bool CheckExistence(String username)
        {
            bool exists = false;

            var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    String[] splitted = line.Split('|');
                    if (username.Equals(splitted[0]))
                    {
                        exists = true;
                        break;
                    }
                }
            }

            return exists;
        }

        public bool FindPasswordMatch(String username, String password)
        {
            bool exists = false;
            String encryptedPass = Encrypt(password);

            var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    String[] splitted = line.Split('|');
                    if (username.Equals(splitted[0]) && encryptedPass.Equals(splitted[1]))
                    {
                        exists = true;
                        break;
                    }
                }
            }

            return exists;
        }

        private String Encrypt(String value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] date = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(date);
            }
        }

        public void RegisterUser(String username, String password)
        {
            String encryptedPass = Encrypt(password);

            var fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            using (var streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
            {
                streamWriter.WriteLine(username + '|' + encryptedPass);
            }
        }
    }
}
