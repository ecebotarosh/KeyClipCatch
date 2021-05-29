namespace ProiectIP
{
    partial class KeyClipCatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddEmail = new System.Windows.Forms.Button();
            this.textBoxInputEmail = new System.Windows.Forms.TextBox();
            this.buttonToggleKeylogging = new System.Windows.Forms.Button();
            this.buttonSendToMailingList = new System.Windows.Forms.Button();
            this.buttonSetClipboardText = new System.Windows.Forms.Button();
            this.buttonGetClipboardImage = new System.Windows.Forms.Button();
            this.textBoxKeylogging = new System.Windows.Forms.TextBox();
            this.buttonGetClipboardText = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonDeleteEmail = new System.Windows.Forms.Button();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.groupBoxEmail = new System.Windows.Forms.GroupBox();
            this.buttonLoadEmails = new System.Windows.Forms.Button();
            this.buttonSaveEmails = new System.Windows.Forms.Button();
            this.groupBoxEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddEmail
            // 
            this.buttonAddEmail.Location = new System.Drawing.Point(6, 20);
            this.buttonAddEmail.Name = "buttonAddEmail";
            this.buttonAddEmail.Size = new System.Drawing.Size(67, 35);
            this.buttonAddEmail.TabIndex = 1;
            this.buttonAddEmail.Text = "+";
            this.buttonAddEmail.UseVisualStyleBackColor = true;
            this.buttonAddEmail.Click += new System.EventHandler(this.buttonAddEmail_Click);
            // 
            // textBoxInputEmail
            // 
            this.textBoxInputEmail.Location = new System.Drawing.Point(79, 25);
            this.textBoxInputEmail.Multiline = true;
            this.textBoxInputEmail.Name = "textBoxInputEmail";
            this.textBoxInputEmail.Size = new System.Drawing.Size(920, 30);
            this.textBoxInputEmail.TabIndex = 2;
            // 
            // buttonToggleKeylogging
            // 
            this.buttonToggleKeylogging.Location = new System.Drawing.Point(938, 115);
            this.buttonToggleKeylogging.Name = "buttonToggleKeylogging";
            this.buttonToggleKeylogging.Size = new System.Drawing.Size(174, 52);
            this.buttonToggleKeylogging.TabIndex = 4;
            this.buttonToggleKeylogging.Text = "Start";
            this.buttonToggleKeylogging.UseVisualStyleBackColor = true;
            this.buttonToggleKeylogging.Click += new System.EventHandler(this.buttonToggleKeylogging_Click);
            // 
            // buttonSendToMailingList
            // 
            this.buttonSendToMailingList.Location = new System.Drawing.Point(937, 529);
            this.buttonSendToMailingList.Name = "buttonSendToMailingList";
            this.buttonSendToMailingList.Size = new System.Drawing.Size(174, 50);
            this.buttonSendToMailingList.TabIndex = 5;
            this.buttonSendToMailingList.Text = "Send to C2";
            this.buttonSendToMailingList.UseVisualStyleBackColor = true;
            this.buttonSendToMailingList.Click += new System.EventHandler(this.buttonSendToMailingList_Click_1);
            // 
            // buttonSetClipboardText
            // 
            this.buttonSetClipboardText.Location = new System.Drawing.Point(938, 304);
            this.buttonSetClipboardText.Name = "buttonSetClipboardText";
            this.buttonSetClipboardText.Size = new System.Drawing.Size(174, 58);
            this.buttonSetClipboardText.TabIndex = 6;
            this.buttonSetClipboardText.Text = "Set Clipboard Text";
            this.buttonSetClipboardText.UseVisualStyleBackColor = true;
            this.buttonSetClipboardText.Click += new System.EventHandler(this.buttonSetClipboardText_Click);
            // 
            // buttonGetClipboardImage
            // 
            this.buttonGetClipboardImage.Location = new System.Drawing.Point(937, 404);
            this.buttonGetClipboardImage.Name = "buttonGetClipboardImage";
            this.buttonGetClipboardImage.Size = new System.Drawing.Size(174, 58);
            this.buttonGetClipboardImage.TabIndex = 7;
            this.buttonGetClipboardImage.Text = "Get Clipboard Image";
            this.buttonGetClipboardImage.UseVisualStyleBackColor = true;
            this.buttonGetClipboardImage.Click += new System.EventHandler(this.buttonGetClipboardImage_Click_1);
            // 
            // textBoxKeylogging
            // 
            this.textBoxKeylogging.Location = new System.Drawing.Point(334, 115);
            this.textBoxKeylogging.Multiline = true;
            this.textBoxKeylogging.Name = "textBoxKeylogging";
            this.textBoxKeylogging.Size = new System.Drawing.Size(550, 464);
            this.textBoxKeylogging.TabIndex = 9;
            // 
            // buttonGetClipboardText
            // 
            this.buttonGetClipboardText.Location = new System.Drawing.Point(938, 240);
            this.buttonGetClipboardText.Name = "buttonGetClipboardText";
            this.buttonGetClipboardText.Size = new System.Drawing.Size(174, 58);
            this.buttonGetClipboardText.TabIndex = 10;
            this.buttonGetClipboardText.Text = "Get Clipboard Text";
            this.buttonGetClipboardText.UseVisualStyleBackColor = true;
            this.buttonGetClipboardText.Click += new System.EventHandler(this.buttonGetClipboardText_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(19, 30);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(125, 52);
            this.buttonHelp.TabIndex = 12;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonDeleteEmail
            // 
            this.buttonDeleteEmail.Enabled = false;
            this.buttonDeleteEmail.Location = new System.Drawing.Point(19, 619);
            this.buttonDeleteEmail.Name = "buttonDeleteEmail";
            this.buttonDeleteEmail.Size = new System.Drawing.Size(67, 35);
            this.buttonDeleteEmail.TabIndex = 1;
            this.buttonDeleteEmail.Text = "-";
            this.buttonDeleteEmail.UseVisualStyleBackColor = true;
            this.buttonDeleteEmail.Click += new System.EventHandler(this.buttonDeleteEmail_Click);
            // 
            // listBoxEmails
            // 
            this.listBoxEmails.FormattingEnabled = true;
            this.listBoxEmails.ItemHeight = 20;
            this.listBoxEmails.Location = new System.Drawing.Point(30, 115);
            this.listBoxEmails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(274, 224);
            this.listBoxEmails.TabIndex = 14;
            this.listBoxEmails.SelectedIndexChanged += new System.EventHandler(this.listBoxEmails_SelectedIndexChanged);
            // 
            // groupBoxEmail
            // 
            this.groupBoxEmail.Controls.Add(this.buttonAddEmail);
            this.groupBoxEmail.Controls.Add(this.textBoxInputEmail);
            this.groupBoxEmail.Location = new System.Drawing.Point(102, 600);
            this.groupBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxEmail.Name = "groupBoxEmail";
            this.groupBoxEmail.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxEmail.Size = new System.Drawing.Size(1019, 61);
            this.groupBoxEmail.TabIndex = 15;
            this.groupBoxEmail.TabStop = false;
            this.groupBoxEmail.Text = "Add Email";
            // 
            // buttonLoadEmails
            // 
            this.buttonLoadEmails.Location = new System.Drawing.Point(30, 390);
            this.buttonLoadEmails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoadEmails.Name = "buttonLoadEmails";
            this.buttonLoadEmails.Size = new System.Drawing.Size(273, 27);
            this.buttonLoadEmails.TabIndex = 17;
            this.buttonLoadEmails.Text = "Load Emails from File";
            this.buttonLoadEmails.UseVisualStyleBackColor = true;
            this.buttonLoadEmails.Click += new System.EventHandler(this.buttonLoadEmails_Click);
            // 
            // buttonSaveEmails
            // 
            this.buttonSaveEmails.Enabled = false;
            this.buttonSaveEmails.Location = new System.Drawing.Point(30, 477);
            this.buttonSaveEmails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveEmails.Name = "buttonSaveEmails";
            this.buttonSaveEmails.Size = new System.Drawing.Size(273, 27);
            this.buttonSaveEmails.TabIndex = 17;
            this.buttonSaveEmails.Text = "Save Emails to File";
            this.buttonSaveEmails.UseVisualStyleBackColor = true;
            this.buttonSaveEmails.Click += new System.EventHandler(this.buttonSaveEmails_Click);
            // 
            // KeyClipCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 840);
            this.Controls.Add(this.buttonSaveEmails);
            this.Controls.Add(this.buttonLoadEmails);
            this.Controls.Add(this.listBoxEmails);
            this.Controls.Add(this.buttonDeleteEmail);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonGetClipboardText);
            this.Controls.Add(this.textBoxKeylogging);
            this.Controls.Add(this.buttonGetClipboardImage);
            this.Controls.Add(this.buttonSetClipboardText);
            this.Controls.Add(this.buttonSendToMailingList);
            this.Controls.Add(this.buttonToggleKeylogging);
            this.Controls.Add(this.groupBoxEmail);
            this.Name = "KeyClipCatch";
            this.Text = "KeyClipCatch";
            this.groupBoxEmail.ResumeLayout(false);
            this.groupBoxEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddEmail;
        private System.Windows.Forms.TextBox textBoxInputEmail;
        private System.Windows.Forms.Button buttonToggleKeylogging;
        private System.Windows.Forms.Button buttonSendToMailingList;
        private System.Windows.Forms.Button buttonSetClipboardText;
        private System.Windows.Forms.Button buttonGetClipboardImage;
        private System.Windows.Forms.TextBox textBoxKeylogging;
        private System.Windows.Forms.Button buttonGetClipboardText;
  
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonDeleteEmail;
        private System.Windows.Forms.ListBox listBoxEmails;
        private System.Windows.Forms.GroupBox groupBoxEmail;
        private System.Windows.Forms.Button buttonLoadEmails;
        private System.Windows.Forms.Button buttonSaveEmails;
    }
}

