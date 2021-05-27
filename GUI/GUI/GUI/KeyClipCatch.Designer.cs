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
            this.richTextBoxEmailList = new System.Windows.Forms.RichTextBox();
            this.buttonToggleKeylogging = new System.Windows.Forms.Button();
            this.buttonSendToMailingList = new System.Windows.Forms.Button();
            this.buttonSetClipboardText = new System.Windows.Forms.Button();
            this.buttonGetClipboardImage = new System.Windows.Forms.Button();
            this.textBoxKeylogging = new System.Windows.Forms.TextBox();
            this.buttonGetClipboardText = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddEmail
            // 
            this.buttonAddEmail.Location = new System.Drawing.Point(19, 605);
            this.buttonAddEmail.Name = "buttonAddEmail";
            this.buttonAddEmail.Size = new System.Drawing.Size(67, 35);
            this.buttonAddEmail.TabIndex = 1;
            this.buttonAddEmail.Text = "+";
            this.buttonAddEmail.UseVisualStyleBackColor = true;
            this.buttonAddEmail.Click += new System.EventHandler(this.AddEmail_Click);
            // 
            // textBoxInputEmail
            // 
            this.textBoxInputEmail.Location = new System.Drawing.Point(104, 605);
            this.textBoxInputEmail.Multiline = true;
            this.textBoxInputEmail.Name = "textBoxInputEmail";
            this.textBoxInputEmail.Size = new System.Drawing.Size(1008, 35);
            this.textBoxInputEmail.TabIndex = 2;
            this.textBoxInputEmail.Text = "Add email:";
            this.textBoxInputEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBoxEmailList
            // 
            this.richTextBoxEmailList.Location = new System.Drawing.Point(19, 108);
            this.richTextBoxEmailList.Name = "richTextBoxEmailList";
            this.richTextBoxEmailList.Size = new System.Drawing.Size(308, 481);
            this.richTextBoxEmailList.TabIndex = 3;
            this.richTextBoxEmailList.Text = "";
            // 
            // buttonToggleKeylogging
            // 
            this.buttonToggleKeylogging.Location = new System.Drawing.Point(938, 39);
            this.buttonToggleKeylogging.Name = "buttonToggleKeylogging";
            this.buttonToggleKeylogging.Size = new System.Drawing.Size(174, 52);
            this.buttonToggleKeylogging.TabIndex = 4;
            this.buttonToggleKeylogging.Text = "Start";
            this.buttonToggleKeylogging.UseVisualStyleBackColor = true;
            this.buttonToggleKeylogging.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // buttonSendToMailingList
            // 
            this.buttonSendToMailingList.Location = new System.Drawing.Point(938, 539);
            this.buttonSendToMailingList.Name = "buttonSendToMailingList";
            this.buttonSendToMailingList.Size = new System.Drawing.Size(174, 50);
            this.buttonSendToMailingList.TabIndex = 5;
            this.buttonSendToMailingList.Text = "Send to C2";
            this.buttonSendToMailingList.UseVisualStyleBackColor = true;
            // 
            // buttonSetClipboardText
            // 
            this.buttonSetClipboardText.Location = new System.Drawing.Point(938, 219);
            this.buttonSetClipboardText.Name = "buttonSetClipboardText";
            this.buttonSetClipboardText.Size = new System.Drawing.Size(174, 58);
            this.buttonSetClipboardText.TabIndex = 6;
            this.buttonSetClipboardText.Text = "Set Clipboard Text";
            this.buttonSetClipboardText.UseVisualStyleBackColor = true;
            this.buttonSetClipboardText.Click += new System.EventHandler(this.ClipboardTextButton_Click);
            // 
            // buttonGetClipboardImage
            // 
            this.buttonGetClipboardImage.Location = new System.Drawing.Point(938, 361);
            this.buttonGetClipboardImage.Name = "buttonGetClipboardImage";
            this.buttonGetClipboardImage.Size = new System.Drawing.Size(174, 58);
            this.buttonGetClipboardImage.TabIndex = 7;
            this.buttonGetClipboardImage.Text = "Get Clipboard Image";
            this.buttonGetClipboardImage.UseVisualStyleBackColor = true;
            // 
            // textBoxKeylogging
            // 
            this.textBoxKeylogging.Location = new System.Drawing.Point(354, 108);
            this.textBoxKeylogging.Multiline = true;
            this.textBoxKeylogging.Name = "textBoxKeylogging";
            this.textBoxKeylogging.Size = new System.Drawing.Size(531, 284);
            this.textBoxKeylogging.TabIndex = 9;
            // 
            // buttonGetClipboardText
            // 
            this.buttonGetClipboardText.Location = new System.Drawing.Point(938, 155);
            this.buttonGetClipboardText.Name = "buttonGetClipboardText";
            this.buttonGetClipboardText.Size = new System.Drawing.Size(174, 58);
            this.buttonGetClipboardText.TabIndex = 10;
            this.buttonGetClipboardText.Text = "Get Clipboard Text";
            this.buttonGetClipboardText.UseVisualStyleBackColor = true;
            this.buttonGetClipboardText.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(19, 30);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(125, 52);
            this.buttonHelp.TabIndex = 12;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // KeyClipCatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 670);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonGetClipboardText);
            this.Controls.Add(this.textBoxKeylogging);
            this.Controls.Add(this.buttonGetClipboardImage);
            this.Controls.Add(this.buttonSetClipboardText);
            this.Controls.Add(this.buttonSendToMailingList);
            this.Controls.Add(this.buttonToggleKeylogging);
            this.Controls.Add(this.richTextBoxEmailList);
            this.Controls.Add(this.textBoxInputEmail);
            this.Controls.Add(this.buttonAddEmail);
            this.Name = "KeyClipCatch";
            this.Text = "KeyClipCatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddEmail;
        private System.Windows.Forms.TextBox textBoxInputEmail;
        private System.Windows.Forms.RichTextBox richTextBoxEmailList;
        private System.Windows.Forms.Button buttonToggleKeylogging;
        private System.Windows.Forms.Button buttonSendToMailingList;
        private System.Windows.Forms.Button buttonSetClipboardText;
        private System.Windows.Forms.Button buttonGetClipboardImage;
        private System.Windows.Forms.TextBox textBoxKeylogging;
        private System.Windows.Forms.Button buttonGetClipboardText;
  
        private System.Windows.Forms.Button buttonHelp;
    }
}

