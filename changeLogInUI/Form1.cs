using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace changeUi
{
    public partial class Form1 : Form
    {
        string p = @"C:\\Windows\\System32\\oobe\\info\\backgrounds\\";

        public Form1()
        {
            InitializeComponent();
            string user2 = Environment.UserName; //extract username
            usrn.Text = user2;          //pass username to label usrn
            pictureBox2.Image = new Bitmap(GetUserimage()); // pass profile pic to picturebox


        }



        public static Image GetUserimage()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Temp\" + Environment.UserName + ".bmp"))
            {
                return Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Temp\" + Environment.UserName + ".bmp");
            }
            else
            {
                string p = @"C:\Windows\Web\Wallpaper\Windows\img0.jpg";
                return Image.FromFile(p);
            }
        }

        private void brws_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File|*.bmp|*.gif|*.jpe|*.jpeg|*.jpg|*.png|*.srf|*.tga|*.tif|*.tiff|*.webp|All Files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                File.Copy(open.FileName, p + "temp.jpg", true);
                pictureBox1.Image = new Bitmap(open.FileName);
            }

            else
            {
                MessageBox.Show("File couldn't be open");
            }

        }

        private void setreg_Click(object sender, EventArgs e)
        {
         try
            {

                RegistryKey rkey;
                rkey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\LogonUI\\Background");
                rkey.SetValue("OEMBackground", "1", RegistryValueKind.DWord);
                rkey.Close();
                MessageBox.Show("done");
            }
            catch (Exception er)
            {
                MessageBox.Show("UnKnown Error == " + er);
            }
        }

        private void setImg_Click(object sender, EventArgs e)
        {
        if (File.Exists(p + "backgroundDefault.jpg"))
            {
                File.Delete(p + "backgroundDefault.jpg");
            }
            File.Copy(p + "temp.jpg", p + "backgroundDefault.jpg", true);
        }

        private void resetreg_Click(object sender, EventArgs e)
        {
             try
            {
                string keyName = @"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Authentication\\LogonUI\\Background";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyName, true))
                {
                    if (key == null)
                    {
                        MessageBox.Show("not set");
                    }
                    else
                    {
                        File.Delete(p + "backgroundDefault.jpg");
                        key.DeleteValue("OEMBackground");
                        MessageBox.Show("Deleted");
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("UnKnown Error == " + er);
            }
        
        
        }

        




    }
}
