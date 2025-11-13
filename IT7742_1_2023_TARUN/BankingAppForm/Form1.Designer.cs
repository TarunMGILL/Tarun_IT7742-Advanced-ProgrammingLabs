namespace BankingAppForm
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox ddlAccount;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button interestBtn;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ListBox logBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ddlAccount = new ComboBox();
            amountBox = new TextBox();
            depositBtn = new Button();
            withdrawBtn = new Button();
            interestBtn = new Button();
            infoBtn = new Button();
            clearBtn = new Button();
            logBox = new ListBox();
            SuspendLayout();
            // 
            // ddlAccount
            // 
            ddlAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlAccount.Items.AddRange(new object[] { "Everyday Account", "Investment Account", "Omni Account" });
            ddlAccount.Location = new Point(30, 20);
            ddlAccount.Name = "ddlAccount";
            ddlAccount.Size = new Size(200, 28);
            ddlAccount.TabIndex = 0;
            // 
            // amountBox
            // 
            amountBox.Location = new Point(250, 20);
            amountBox.Name = "amountBox";
            amountBox.PlaceholderText = "Amount";
            amountBox.Size = new Size(100, 27);
            amountBox.TabIndex = 1;
            // 
            // depositBtn
            // 
            depositBtn.BackColor = Color.LightSteelBlue;
            depositBtn.Location = new Point(379, 21);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(151, 27);
            depositBtn.TabIndex = 2;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = false;
            depositBtn.Click += depositBtn_Click;
            // 
            // withdrawBtn
            // 
            withdrawBtn.BackColor = Color.LightSteelBlue;
            withdrawBtn.Location = new Point(546, 58);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(122, 27);
            withdrawBtn.TabIndex = 3;
            withdrawBtn.Text = "Withdraw";
            withdrawBtn.UseVisualStyleBackColor = false;
            withdrawBtn.Click += withdrawBtn_Click;
            // 
            // interestBtn
            // 
            interestBtn.BackColor = Color.LightSteelBlue;
            interestBtn.Location = new Point(379, 59);
            interestBtn.Name = "interestBtn";
            interestBtn.Size = new Size(151, 27);
            interestBtn.TabIndex = 4;
            interestBtn.Text = "Add Interest";
            interestBtn.UseVisualStyleBackColor = false;
            interestBtn.Click += interestBtn_Click;
            // 
            // infoBtn
            // 
            infoBtn.BackColor = Color.Gainsboro;
            infoBtn.Location = new Point(546, 20);
            infoBtn.Name = "infoBtn";
            infoBtn.Size = new Size(122, 25);
            infoBtn.TabIndex = 5;
            infoBtn.Text = "Account Info";
            infoBtn.UseVisualStyleBackColor = false;
            infoBtn.Click += infoBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Gainsboro;
            clearBtn.Location = new Point(30, 60);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(110, 25);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear Log";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // logBox
            // 
            logBox.BackColor = Color.WhiteSmoke;
            logBox.Font = new Font("Consolas", 10F);
            logBox.Location = new Point(30, 100);
            logBox.Name = "logBox";
            logBox.Size = new Size(600, 244);
            logBox.TabIndex = 7;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(744, 380);
            Controls.Add(ddlAccount);
            Controls.Add(amountBox);
            Controls.Add(depositBtn);
            Controls.Add(withdrawBtn);
            Controls.Add(interestBtn);
            Controls.Add(infoBtn);
            Controls.Add(clearBtn);
            Controls.Add(logBox);
            Name = "Form1";
            Text = "Bank Application Form";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
