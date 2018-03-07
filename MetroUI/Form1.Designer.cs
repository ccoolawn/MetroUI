namespace MetroUI
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
            this.components = new System.ComponentModel.Container();
            this.msnMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnLight = new MetroFramework.Controls.MetroButton();
            this.btnDark = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.btnChangeStyle = new MetroFramework.Controls.MetroButton();
            this.btnShowChild = new MetroFramework.Controls.MetroButton();
            this.btnMessageBox = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.msnMain)).BeginInit();
            this.SuspendLayout();
            // 
            // msnMain
            // 
            this.msnMain.Owner = this;
            this.msnMain.Style = MetroFramework.MetroColorStyle.Orange;
            this.msnMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnLight
            // 
            this.btnLight.BackColor = System.Drawing.Color.White;
            this.btnLight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLight.Location = new System.Drawing.Point(54, 128);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(133, 62);
            this.btnLight.TabIndex = 0;
            this.btnLight.Text = "Light";
            this.btnLight.UseSelectable = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // btnDark
            // 
            this.btnDark.Location = new System.Drawing.Point(54, 196);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(133, 62);
            this.btnDark.TabIndex = 1;
            this.btnDark.Text = "Dark";
            this.btnDark.UseSelectable = true;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.metroComboBox1.Location = new System.Drawing.Point(245, 128);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // btnChangeStyle
            // 
            this.btnChangeStyle.BackColor = System.Drawing.Color.White;
            this.btnChangeStyle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeStyle.Location = new System.Drawing.Point(374, 128);
            this.btnChangeStyle.Name = "btnChangeStyle";
            this.btnChangeStyle.Size = new System.Drawing.Size(133, 29);
            this.btnChangeStyle.TabIndex = 3;
            this.btnChangeStyle.Text = "Change Style";
            this.btnChangeStyle.UseSelectable = true;
            this.btnChangeStyle.Click += new System.EventHandler(this.btnChangeStyle_Click);
            // 
            // btnShowChild
            // 
            this.btnShowChild.Location = new System.Drawing.Point(374, 163);
            this.btnShowChild.Name = "btnShowChild";
            this.btnShowChild.Size = new System.Drawing.Size(133, 62);
            this.btnShowChild.TabIndex = 4;
            this.btnShowChild.Text = "Show Chlid";
            this.btnShowChild.UseSelectable = true;
            this.btnShowChild.Click += new System.EventHandler(this.btnShowChild_Click);
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(374, 231);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(133, 42);
            this.btnMessageBox.TabIndex = 5;
            this.btnMessageBox.Text = "Message Box";
            this.btnMessageBox.UseSelectable = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 430);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.btnShowChild);
            this.Controls.Add(this.btnChangeStyle);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btnDark);
            this.Controls.Add(this.btnLight);
            this.Name = "Form1";
            this.Text = "Test UI";
            ((System.ComponentModel.ISupportInitialize)(this.msnMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager msnMain;
        private MetroFramework.Controls.MetroButton btnLight;
        private MetroFramework.Controls.MetroButton btnDark;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton btnChangeStyle;
        private MetroFramework.Controls.MetroButton btnShowChild;
        private MetroFramework.Controls.MetroButton btnMessageBox;
    }
}

