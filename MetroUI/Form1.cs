using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroUI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = msnMain;
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            msnMain.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            msnMain.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void btnChangeStyle_Click(object sender, EventArgs e)
        {
            msnMain.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(metroComboBox1.Text);
        }

        private void btnShowChild_Click(object sender, EventArgs e)
        {
            ChildForm _child = new ChildForm();
            _child.StyleManager = this.StyleManager;
            _child.ShowDialog();
            _child.Dispose();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Look at this Flat UI!!!!");
        }
    }
}
