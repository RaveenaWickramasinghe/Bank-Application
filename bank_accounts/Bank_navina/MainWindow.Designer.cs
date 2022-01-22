
namespace Bank_navina
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBalanceClick = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawMoneyClick = new System.Windows.Forms.ToolStripMenuItem();
            this.depositMoneyClick = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountClick = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.withdrawMoneyToolStripMenuItem,
            this.checkBalanceToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.CheckOnClick = true;
            this.newAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountClick});
            this.newAccountToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.newAccountToolStripMenuItem.Text = "Account";
            // 
            // withdrawMoneyToolStripMenuItem
            // 
            this.withdrawMoneyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withdrawMoneyClick,
            this.depositMoneyClick});
            this.withdrawMoneyToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawMoneyToolStripMenuItem.Name = "withdrawMoneyToolStripMenuItem";
            this.withdrawMoneyToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.withdrawMoneyToolStripMenuItem.Text = "Transactions";
            this.withdrawMoneyToolStripMenuItem.Click += new System.EventHandler(this.withdrawMoneyToolStripMenuItem_Click);
            // 
            // checkBalanceToolStripMenuItem
            // 
            this.checkBalanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBalanceClick});
            this.checkBalanceToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBalanceToolStripMenuItem.Name = "checkBalanceToolStripMenuItem";
            this.checkBalanceToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.checkBalanceToolStripMenuItem.Text = "View";
            // 
            // checkBalanceClick
            // 
            this.checkBalanceClick.Name = "checkBalanceClick";
            this.checkBalanceClick.Size = new System.Drawing.Size(180, 24);
            this.checkBalanceClick.Text = "Check Balance";
            this.checkBalanceClick.Click += new System.EventHandler(this.checkBalanceToolStripMenuItem1_Click);
            // 
            // withdrawMoneyClick
            // 
            this.withdrawMoneyClick.Name = "withdrawMoneyClick";
            this.withdrawMoneyClick.Size = new System.Drawing.Size(180, 24);
            this.withdrawMoneyClick.Text = "Withdraw Money";
            this.withdrawMoneyClick.Click += new System.EventHandler(this.withdrawMoneyToolStripMenuItem1_Click);
            // 
            // depositMoneyClick
            // 
            this.depositMoneyClick.Name = "depositMoneyClick";
            this.depositMoneyClick.Size = new System.Drawing.Size(180, 24);
            this.depositMoneyClick.Text = "Deposit Money";
            this.depositMoneyClick.Click += new System.EventHandler(this.depositMoneyToolStripMenuItem_Click);
            // 
            // newAccountClick
            // 
            this.newAccountClick.Name = "newAccountClick";
            this.newAccountClick.Size = new System.Drawing.Size(180, 24);
            this.newAccountClick.Text = "New Account";
            this.newAccountClick.Click += new System.EventHandler(this.newAccountToolStripMenuItem1_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.otherToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBalanceClick;
        private System.Windows.Forms.ToolStripMenuItem newAccountClick;
        private System.Windows.Forms.ToolStripMenuItem withdrawMoneyClick;
        private System.Windows.Forms.ToolStripMenuItem depositMoneyClick;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}