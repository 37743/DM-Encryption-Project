namespace DM_Encryption_Project
{
    partial class window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            encryptBox = new TextBox();
            groupBox1 = new GroupBox();
            decryptText = new Label();
            encryptText = new Label();
            decryptBox = new TextBox();
            decrypt = new Button();
            encrypt = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // encryptBox
            // 
            encryptBox.Location = new Point(6, 35);
            encryptBox.Name = "encryptBox";
            encryptBox.Size = new Size(248, 23);
            encryptBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(decryptText);
            groupBox1.Controls.Add(encryptText);
            groupBox1.Controls.Add(decryptBox);
            groupBox1.Controls.Add(decrypt);
            groupBox1.Controls.Add(encrypt);
            groupBox1.Controls.Add(encryptBox);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 146);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // decryptText
            // 
            decryptText.AutoSize = true;
            decryptText.Location = new Point(6, 67);
            decryptText.Name = "decryptText";
            decryptText.Size = new Size(152, 15);
            decryptText.TabIndex = 5;
            decryptText.Text = "Enter text below to decrypt:";
            // 
            // encryptText
            // 
            encryptText.AutoSize = true;
            encryptText.Location = new Point(6, 17);
            encryptText.Name = "encryptText";
            encryptText.Size = new Size(152, 15);
            encryptText.TabIndex = 4;
            encryptText.Text = "Enter text below to encrypt:";
            // 
            // decryptBox
            // 
            decryptBox.Location = new Point(6, 85);
            decryptBox.Name = "decryptBox";
            decryptBox.Size = new Size(248, 23);
            decryptBox.TabIndex = 3;
            // 
            // decrypt
            // 
            decrypt.Location = new Point(154, 117);
            decrypt.Name = "decrypt";
            decrypt.Size = new Size(100, 23);
            decrypt.TabIndex = 2;
            decrypt.Text = "Decrypt";
            decrypt.UseVisualStyleBackColor = true;
            decrypt.Click += decrypt_Click;
            // 
            // encrypt
            // 
            encrypt.Location = new Point(6, 117);
            encrypt.Name = "encrypt";
            encrypt.Size = new Size(100, 23);
            encrypt.TabIndex = 1;
            encrypt.Text = "Encrypt";
            encrypt.UseVisualStyleBackColor = true;
            encrypt.Click += encrypt_Click;
            // 
            // window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(groupBox1);
            Name = "window";
            Text = "Encryption Project - 207";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox encryptBox;
        private GroupBox groupBox1;
        private TextBox decryptBox;
        private Button decrypt;
        private Button encrypt;
        private Label encryptText;
        private Label decryptText;
    }
}