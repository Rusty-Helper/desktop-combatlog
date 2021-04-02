/*
 * Source Provided By Rusty Helper
 * Program Created By icey#1397
 * This is the starter form where people choose where rust is installed
 * 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustCL
{
    public partial class frmStarter : Form
    {
        public frmStarter()
        {
            InitializeComponent();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void fileLocation_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select Application";
            theDialog.Filter = "EXE files|*.exe";
            theDialog.InitialDirectory = @"C:\";

            if(theDialog.ShowDialog() == DialogResult.OK)
            {
                string location = theDialog.FileName;

                if (location == "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rust\\Rust.exe" | location == "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rust\\RustClient.exe")
                {
                    try
                    {
                        location = location.Replace("Rust.exe", "");
                    }
                    catch { }

                    try
                    {
                        location = location.Replace("RustClient.exe", "");
                    }
                    catch { }
                    MessageBox.Show(location);
                    this.Hide();
                    new frmMain().Show();
                    Properties.Settings.Default.rustlocation = location;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Please Select Rust Location!", "Error");
                }
            }

        }

        private void fileLocation_Load(object sender, EventArgs e)
        {

#if DEBUG
            Properties.Settings.Default.rustlocation = "";
            Properties.Settings.Default.Save();
#endif
            if (File.Exists(Properties.Settings.Default.rustlocation + "\\RustClient.exe")|| File.Exists(Properties.Settings.Default.rustlocation+"\\Rust.exe"))
            {
                this.Hide();
                new frmMain().Show();
            }
        }
    }
}
