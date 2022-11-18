using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmProjectSetup
{
    public partial class Form1 : Form
    {

        //defin global variable
        string filePath = "";
        string filePath2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLevelFile_Click(object sender, EventArgs e)
        {
            //TaskDialog.Show("Test", "On file button Click!");
            //string filePath = "";
   
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"M:\OneDrive - Mon & Associates Inc\Library\REIVT\REVIT ADDIN BOOTCAMP\Download";
            ofd.Title = "Floor Level Data File";
            ofd.Filter = "Excel CSV|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                //TaskDialog.Show("Test", ofd.FileName);
                this.tbLevelTemplate.Text = filePath;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetFilePath()
        {
            //Result = GetFilePath();
            return tbLevelTemplate.Text;
        }

        private void btnOPenSheetDataFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"M:\OneDrive - Mon & Associates Inc\Library\REIVT\REVIT ADDIN BOOTCAMP\Download";
            ofd.Title = "Floor Level Data File";
            ofd.Filter = "Excel CSV|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath2 = ofd.FileName;
                //TaskDialog.Show("Test", ofd.FileName);
                this.tbSheetTemplatePath.Text = filePath2;
            }

        }
    }
}
