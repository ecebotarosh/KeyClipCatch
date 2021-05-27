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
            this.AddEmail = new System.Windows.Forms.Button();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.EmailList = new System.Windows.Forms.RichTextBox();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.SendAllButton = new System.Windows.Forms.Button();
            this.ClipboardTextButton = new System.Windows.Forms.Button();
            this.ClipboarImageButton = new System.Windows.Forms.Button();
            this.TextBOX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEmail
            // 
            this.AddEmail.Location = new System.Drawing.Point(21, 605);
            this.AddEmail.Name = "AddEmail";
            this.AddEmail.Size = new System.Drawing.Size(75, 35);
            this.AddEmail.TabIndex = 1;
            this.AddEmail.Text = "+";
            this.AddEmail.UseVisualStyleBackColor = true;
            this.AddEmail.Click += new System.EventHandler(this.AddEmail_Click);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(117, 605);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(1134, 35);
            this.EmailText.TabIndex = 2;
            this.EmailText.Text = "Add email:";
            this.EmailText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailList
            // 
            this.EmailList.Location = new System.Drawing.Point(21, 108);
            this.EmailList.Name = "EmailList";
            this.EmailList.Size = new System.Drawing.Size(346, 481);
            this.EmailList.TabIndex = 3;
            this.EmailList.Text = "";
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(1055, 39);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(196, 52);
            this.StartStopButton.TabIndex = 4;
            this.StartStopButton.Text = "START";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // SendAllButton
            // 
            this.SendAllButton.Location = new System.Drawing.Point(1055, 539);
            this.SendAllButton.Name = "SendAllButton";
            this.SendAllButton.Size = new System.Drawing.Size(196, 50);
            this.SendAllButton.TabIndex = 5;
            this.SendAllButton.Text = "SEND ALL";
            this.SendAllButton.UseVisualStyleBackColor = true;
            // 
            // ClipboardTextButton
            // 
            this.ClipboardTextButton.Location = new System.Drawing.Point(1055, 219);
            this.ClipboardTextButton.Name = "ClipboardTextButton";
            this.ClipboardTextButton.Size = new System.Drawing.Size(196, 58);
            this.ClipboardTextButton.TabIndex = 6;
            this.ClipboardTextButton.Text = "Set Clipboard Text";
            this.ClipboardTextButton.UseVisualStyleBackColor = true;
            this.ClipboardTextButton.Click += new System.EventHandler(this.ClipboardTextButton_Click);
            // 
            // ClipboarImageButton
            // 
            this.ClipboarImageButton.Location = new System.Drawing.Point(1055, 361);
            this.ClipboarImageButton.Name = "ClipboarImageButton";
            this.ClipboarImageButton.Size = new System.Drawing.Size(196, 58);
            this.ClipboarImageButton.TabIndex = 7;
            this.ClipboarImageButton.Text = "Get Clipboard Image";
            this.ClipboarImageButton.UseVisualStyleBackColor = true;
            // 
            // TextBOX
            // 
            this.TextBOX.Location = new System.Drawing.Point(398, 108);
            this.TextBOX.Multiline = true;
            this.TextBOX.Name = "TextBOX";
            this.TextBOX.Size = new System.Drawing.Size(597, 284);
            this.TextBOX.TabIndex = 9;
            this.TextBOX.Text = "TEXT: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1055, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 58);
            this.button1.TabIndex = 10;
            this.button1.Text = "Get Clipboard Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "OpenFileDiag";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(21, 30);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(141, 52);
            this.Help.TabIndex = 12;
            this.Help.Text = "HELP";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 670);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBOX);
            this.Controls.Add(this.ClipboarImageButton);
            this.Controls.Add(this.ClipboardTextButton);
            this.Controls.Add(this.SendAllButton);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.EmailList);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.AddEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddEmail;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.RichTextBox EmailList;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Button SendAllButton;
        private System.Windows.Forms.Button ClipboardTextButton;
        private System.Windows.Forms.Button ClipboarImageButton;
        private System.Windows.Forms.TextBox TextBOX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Help;
    }
}

