using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Cleaner
{
    public partial class Form1 : Form
    {
        public static string name = Environment.UserName;
        public static string WindowT = @"C:\Windows\Temp";
        public static string Prefetch = @"C:\Windows\Prefetch";
        public static string SWD12 = @"C:\Windows\SoftwareDistribution\Download";
        public static string Recent = @"C:\Users\ESPADA\Recent";
        public static string LocalTemp = @"C:\Users\" + name + @"\AppData\Local\Temp";

        public static void Recrent()
        {
            try
            {
                string[] RecFil = Directory.GetFiles(Recent);
                foreach (string s6 in RecFil)
                {
                    try
                    {
                        File.Delete(s6);
                    }
                    catch (Exception b) { return; }
                }
            }catch (Exception b) { return; }
        }
        public static void SWDUL()
        {
            try
            {
                string[] SWDir = Directory.GetDirectories(SWD12);
                foreach (string s5 in SWDir)
                {
                    try
                    {
                        Directory.Delete(s5, true);
                    }
                    catch (Exception b) { return; }
                }
            }catch (Exception b) { return; }
        }
        public static void Pref123()
        {
            try
            {
                Directory.Delete(Prefetch, true);
            }
            catch (Exception) { return; }
        }
        public static void WindowsTemp()
        {
            string[] WinTeFil = Directory.GetFiles(WindowT);
            foreach (string s3 in WinTeFil)
            {
                try
                {
                    File.Delete(s3);
                }
                catch (Exception c) { return; }
            }
            string[] WinTemDir = Directory.GetDirectories(WindowT);
            foreach (string s4 in WinTemDir)
            {
                try
                {
                    Directory.Delete(s4, true);
                }
                catch (Exception b) { return; }
            }
        }
        public static void AppDataTemp()
        {
            try
            {
                Directory.Delete(LocalTemp, true);
            }
            catch (Exception) { return; }
        }

        public static void WinSxS()
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Arguments = "/k Dism.exe /online /cleanup-image /StartComponentCleanup && exit";
                Process.Start(psi);
            }
            catch (Exception n) { return; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CLOSE_MouseEnter(object sender, EventArgs e)
        {
            CLOSE.ForeColor = Color.Gray;
        }

        private void CLOSE_MouseLeave(object sender, EventArgs e)
        {
            CLOSE.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Gray;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void wins_MouseEnter(object sender, EventArgs e)
        {
            wins.ForeColor = Color.Gray;
        }

        private void wins_MouseLeave(object sender, EventArgs e)
        {
            wins.ForeColor = Color.White;
        }

        private void WindowsPath_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Windows\Temp");
        }

        private void AppDataPath_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\ESPADA\AppData\Local\Temp");
        }

        private void WinSxSPath_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Windows\WinSxS");
        }

        private void Pref_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Windows\Prefetch");
        }

        private void SWD_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Windows\SoftwareDistribution\Download");
        }

        private void ReceDir_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\ESPADA\Recent");
        }
        private void wins_Click(object sender, EventArgs e)
        {
            WinSxS();
            Thread.Sleep(5000);
            MessageBox.Show("Done!", "Message");
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Recrent();
            SWDUL();
            Pref123();
            WindowsTemp();
            AppDataTemp();
            Thread.Sleep(3000);
            MessageBox.Show("Done!", "Message");
        }
    }
}
