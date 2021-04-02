/*
 * Source Provided By Rusty Helper
 * Program Created By icey#1397
 * p.s dont mind the messy code as it will be more put together as I put more work into it lol
 * 
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using antfx;
namespace RustCL
{
    public partial class frmMain : Form
    {
        string rustlocation = $"{Properties.Settings.Default.rustlocation}\\output_log.txt";
        public frmMain()
        {
            InitializeComponent(); hideSubMenu();
            var monitor = new LogFileMonitor(rustlocation, "\r\n");
            monitor.OnLine += (s, e) =>
            {
                pullfile();
            };
            monitor.Start();
        }
        string line;
        int watcher = 0;
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            if (watcher == 0)
            {
                pullfile();
                watcher++;
            }
            else
            {
                watcher = 0;
            }
        }
        string text;
        int lnmbr;
        int lastnumber;
        string cast;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(rustlocation);
            pullfile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelChildForm.Controls.Clear();
            poss2 = 2;
        }
        string getline(string fileName, int line)
        {
            using (var fs = new FileStream(rustlocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }
        string test;
        string finale;
        public void normalize(string testing)
        {
            string[] myString = testing.Split(' ');

            foreach (string item in myString)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    finale = finale + item + " ";
                }
            }
            string[] ok = finale.Split(' ');
            finale = "";
            addLog(ok[0], ok[1], ok[2], ok[3], ok[4], ok[5], ok[6], ok[7], ok[8], ok[9], ok[10], ok[11]);
        }
        public void clearPanel()
        {
            if (panelChildForm.InvokeRequired)
            {
                poss2 = 2;
                panelChildForm.Invoke(new MethodInvoker(delegate { panelChildForm.Controls.Clear(); }));
            }
            else
            {poss2 = 2;
                panelChildForm.Controls.Clear();

                panelChildForm.Refresh();
            }
        }

        public void pullfile()
        {
            clearPanel();
            lnmbr = 0;
            lastnumber = 0;
            using (var fs = new FileStream(rustlocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                text = sr.ReadToEnd();
                using (StringReader file = new StringReader(text))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        lnmbr++;
                        if (line.Contains("attacker"))
                        {
                            lastnumber = lnmbr;
                           
                        }

                    }
                    int counter = 0;
                    while (counter < 35)
                    {
                        try
                        {
                            cast = getline(rustlocation, lastnumber);
                            if (cast.Contains("you"))
                            {
                                normalize(cast + "\n");
                            }
                        }
                        catch
                        {

                        }
                        lastnumber++;
                            counter++;
                    }
                }
            }
        }
        int poss2 = 2;
        public void addLog(string time, string attacker, string id, string target, string id2, string weapon, string ammo, string area, string distance, string oldhp, string newhp, string info)
        {
         
            if (panelChildForm.InvokeRequired)
            {
                panelChildForm.Invoke(new MethodInvoker(delegate { ctrlLogger log = new ctrlLogger(time, attacker, id, target, id2, weapon, ammo, area, distance, oldhp, newhp, info); panelChildForm.Controls.Add(log); log.Top = poss2; poss2 = (log.Top + log.Height + 2); }));
            }
            else
            {
                ctrlLogger log = new ctrlLogger(time, attacker, id, target, id2, weapon, ammo, area, distance, oldhp, newhp, info);
                panelChildForm.Controls.Add(log);
                log.Top = poss2;
                poss2 = (log.Top + log.Height + 2);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addLog("test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test", "test");
        }
    }
}
