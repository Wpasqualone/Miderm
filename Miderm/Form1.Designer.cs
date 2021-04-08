
namespace Miderm
{
    partial class Form1
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
            this.accountNumber = new System.Windows.Forms.TextBox();
            this.accountPin = new System.Windows.Forms.TextBox();
            this.ANlabel = new System.Windows.Forms.Label();
            this.PNlabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountNumber
            // 
            this.accountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumber.Location = new System.Drawing.Point(316, 75);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(155, 26);
            this.accountNumber.TabIndex = 0;
            // 
            // accountPin
            // 
            this.accountPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountPin.Location = new System.Drawing.Point(316, 181);
            this.accountPin.Name = "accountPin";
            this.accountPin.Size = new System.Drawing.Size(155, 26);
            this.accountPin.TabIndex = 1;
            // 
            // ANlabel
            // 
            this.ANlabel.AutoSize = true;
            this.ANlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANlabel.Location = new System.Drawing.Point(124, 75);
            this.ANlabel.Name = "ANlabel";
            this.ANlabel.Size = new System.Drawing.Size(128, 20);
            this.ANlabel.TabIndex = 2;
            this.ANlabel.Text = "Account Number";
            // 
            // PNlabel
            // 
            this.PNlabel.AutoSize = true;
            this.PNlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNlabel.Location = new System.Drawing.Point(158, 181);
            this.PNlabel.Name = "PNlabel";
            this.PNlabel.Size = new System.Drawing.Size(94, 20);
            this.PNlabel.TabIndex = 3;
            this.PNlabel.Text = "Account Pin";
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(316, 242);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(155, 56);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.PNlabel);
            this.Controls.Add(this.ANlabel);
            this.Controls.Add(this.accountPin);
            this.Controls.Add(this.accountNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountNumber;
        private System.Windows.Forms.TextBox accountPin;
        private System.Windows.Forms.Label ANlabel;
        private System.Windows.Forms.Label PNlabel;
        private System.Windows.Forms.Button logInButton;
    }
}

