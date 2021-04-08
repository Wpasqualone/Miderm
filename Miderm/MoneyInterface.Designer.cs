
namespace Miderm
{
    partial class MoneyInterface
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
            this.wcheckbox = new System.Windows.Forms.TextBox();
            this.wcheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wsave = new System.Windows.Forms.Button();
            this.wsavebox = new System.Windows.Forms.TextBox();
            this.checkinglabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dsave = new System.Windows.Forms.Button();
            this.dsavebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dcheck = new System.Windows.Forms.Button();
            this.dcheckbox = new System.Windows.Forms.TextBox();
            this.savingslabel = new System.Windows.Forms.Label();
            this.sendbutton = new System.Windows.Forms.Button();
            this.sendbox2 = new System.Windows.Forms.TextBox();
            this.sendbox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wcheckbox
            // 
            this.wcheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcheckbox.Location = new System.Drawing.Point(394, 103);
            this.wcheckbox.Name = "wcheckbox";
            this.wcheckbox.Size = new System.Drawing.Size(138, 26);
            this.wcheckbox.TabIndex = 0;
            // 
            // wcheck
            // 
            this.wcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcheck.Location = new System.Drawing.Point(394, 149);
            this.wcheck.Name = "wcheck";
            this.wcheck.Size = new System.Drawing.Size(138, 49);
            this.wcheck.TabIndex = 1;
            this.wcheck.Text = "Withdraw";
            this.wcheck.UseVisualStyleBackColor = true;
            this.wcheck.Click += new System.EventHandler(this.wcheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount to withdraw \r\nfrom Checking:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount to withdraw\r\nfrom Savings";
            // 
            // wsave
            // 
            this.wsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wsave.Location = new System.Drawing.Point(24, 149);
            this.wsave.Name = "wsave";
            this.wsave.Size = new System.Drawing.Size(138, 49);
            this.wsave.TabIndex = 4;
            this.wsave.Text = "Withdraw";
            this.wsave.UseVisualStyleBackColor = true;
            this.wsave.Click += new System.EventHandler(this.wsave_Click);
            // 
            // wsavebox
            // 
            this.wsavebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wsavebox.Location = new System.Drawing.Point(24, 103);
            this.wsavebox.Name = "wsavebox";
            this.wsavebox.Size = new System.Drawing.Size(138, 26);
            this.wsavebox.TabIndex = 3;
            // 
            // checkinglabel
            // 
            this.checkinglabel.AutoSize = true;
            this.checkinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinglabel.Location = new System.Drawing.Point(389, 9);
            this.checkinglabel.Name = "checkinglabel";
            this.checkinglabel.Size = new System.Drawing.Size(208, 20);
            this.checkinglabel.TabIndex = 9;
            this.checkinglabel.Text = "Checking Account Balance: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 40);
            this.label3.TabIndex = 15;
            this.label3.Text = "Amount to deposit \r\nin Savings";
            // 
            // dsave
            // 
            this.dsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsave.Location = new System.Drawing.Point(204, 149);
            this.dsave.Name = "dsave";
            this.dsave.Size = new System.Drawing.Size(138, 49);
            this.dsave.TabIndex = 14;
            this.dsave.Text = "Deposit";
            this.dsave.UseVisualStyleBackColor = true;
            this.dsave.Click += new System.EventHandler(this.dsave_Click);
            // 
            // dsavebox
            // 
            this.dsavebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsavebox.Location = new System.Drawing.Point(204, 103);
            this.dsavebox.Name = "dsavebox";
            this.dsavebox.Size = new System.Drawing.Size(138, 26);
            this.dsavebox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount to deposit \r\nin Checking:\r\n";
            // 
            // dcheck
            // 
            this.dcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcheck.Location = new System.Drawing.Point(569, 149);
            this.dcheck.Name = "dcheck";
            this.dcheck.Size = new System.Drawing.Size(138, 49);
            this.dcheck.TabIndex = 11;
            this.dcheck.Text = "Deposit";
            this.dcheck.UseVisualStyleBackColor = true;
            this.dcheck.Click += new System.EventHandler(this.dcheck_Click);
            // 
            // dcheckbox
            // 
            this.dcheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcheckbox.Location = new System.Drawing.Point(569, 103);
            this.dcheckbox.Name = "dcheckbox";
            this.dcheckbox.Size = new System.Drawing.Size(138, 26);
            this.dcheckbox.TabIndex = 10;
            // 
            // savingslabel
            // 
            this.savingslabel.AutoSize = true;
            this.savingslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingslabel.Location = new System.Drawing.Point(20, 9);
            this.savingslabel.Name = "savingslabel";
            this.savingslabel.Size = new System.Drawing.Size(198, 20);
            this.savingslabel.TabIndex = 16;
            this.savingslabel.Text = "Savings Account Balance: ";
            // 
            // sendbutton
            // 
            this.sendbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbutton.Location = new System.Drawing.Point(866, 149);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(138, 49);
            this.sendbutton.TabIndex = 18;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // sendbox2
            // 
            this.sendbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbox2.Location = new System.Drawing.Point(866, 103);
            this.sendbox2.Name = "sendbox2";
            this.sendbox2.Size = new System.Drawing.Size(138, 26);
            this.sendbox2.TabIndex = 17;
            // 
            // sendbox1
            // 
            this.sendbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbox1.Location = new System.Drawing.Point(866, 53);
            this.sendbox1.Name = "sendbox1";
            this.sendbox1.Size = new System.Drawing.Size(138, 26);
            this.sendbox1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(783, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(780, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Account";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(878, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Send Money";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(464, 230);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(155, 56);
            this.logoutButton.TabIndex = 23;
            this.logoutButton.Text = "Quit";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MoneyInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 315);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sendbox1);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.sendbox2);
            this.Controls.Add(this.savingslabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dsave);
            this.Controls.Add(this.dsavebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dcheck);
            this.Controls.Add(this.dcheckbox);
            this.Controls.Add(this.checkinglabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wsave);
            this.Controls.Add(this.wsavebox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wcheck);
            this.Controls.Add(this.wcheckbox);
            this.Name = "MoneyInterface";
            this.Text = "x";
            this.Load += new System.EventHandler(this.MoneyInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wcheckbox;
        private System.Windows.Forms.Button wcheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wsave;
        private System.Windows.Forms.TextBox wsavebox;
        private System.Windows.Forms.Label checkinglabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dsave;
        private System.Windows.Forms.TextBox dsavebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dcheck;
        private System.Windows.Forms.TextBox dcheckbox;
        private System.Windows.Forms.Label savingslabel;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.TextBox sendbox2;
        private System.Windows.Forms.TextBox sendbox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button logoutButton;
    }
}