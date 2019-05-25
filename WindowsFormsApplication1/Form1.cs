using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kopyalanacakDosya = "", dosyanınKopyanacagiKlasor = "", kopyalanacakDosyaIsmi = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Recovery Dosyası|*.img";
            openfile.Title = ".img Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                kopyalanacakDosyaIsmi = openfile.SafeFileName.ToString();
                kopyalanacakDosya = openfile.FileName.ToString();
                recoveryoluTextBox.Text = kopyalanacakDosya;
                dosyanınKopyanacagiKlasor = Application.StartupPath.ToString();
                File.Copy(kopyalanacakDosya, dosyanınKopyanacagiKlasor + "\\" + "recovery.img");

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete("recovery.img");

        }

        private void recoveryoluTextBox_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "Recovery Seçildi.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            console.Clear();
            {
                {

                    {

                        Process process = new Process();
                        Process process2 = new Process();
                        Process process3 = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        ProcessStartInfo startInfo2 = new ProcessStartInfo();
                        ProcessStartInfo startInfo3 = new ProcessStartInfo();
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo3.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo.CreateNoWindow = true;
                        startInfo2.CreateNoWindow = true;
                        startInfo3.CreateNoWindow = true;
                        startInfo.UseShellExecute = false;
                        startInfo2.UseShellExecute = false;
                        startInfo3.UseShellExecute = false;
                        startInfo.RedirectStandardOutput = true;
                        startInfo2.RedirectStandardOutput = true;
                        startInfo3.RedirectStandardOutput = true;
                        startInfo.FileName = "adb.exe";
                        startInfo2.FileName = "adb.exe";
                        startInfo3.FileName = "adb.exe";
                        startInfo.Arguments = " shell getprop ro.product.model ";
                        startInfo2.Arguments = " shell getprop ro.product.manufacturer ";
                        startInfo3.Arguments = " shell getprop ro.build.version.release";
                        process.StartInfo = startInfo;
                        process2.StartInfo = startInfo2;
                        process3.StartInfo = startInfo3;
                        process.Start();
                        process2.Start();
                        process3.Start();
                        label8.Text = process.StandardOutput.ReadToEnd();
                        label10.Text = process2.StandardOutput.ReadToEnd();
                        label13.Text = process3.StandardOutput.ReadToEnd();
                        if (label10.Text != "Cihaz Bağlı Değil")
                        {
                            Process aprocess = new Process();
                            Process aprocess2 = new Process();
                            Process aprocess3 = new Process();
                            Process process4 = new Process();
                            Process process5 = new Process();
                            Process process6 = new Process();
                            Process process7 = new Process();
                            Process process8 = new Process();
                            Process process9 = new Process();
                            Process process10 = new Process();
                            Process process11 = new Process();
                            Process process12 = new Process();
                            ProcessStartInfo astartInfo = new ProcessStartInfo();
                            ProcessStartInfo astartInfo2 = new ProcessStartInfo();
                            ProcessStartInfo astartInfo3 = new ProcessStartInfo();
                            ProcessStartInfo startInfo4 = new ProcessStartInfo();
                            ProcessStartInfo startInfo5 = new ProcessStartInfo();
                            ProcessStartInfo startInfo6 = new ProcessStartInfo();
                            ProcessStartInfo startInfo7 = new ProcessStartInfo();
                            ProcessStartInfo startInfo8 = new ProcessStartInfo();
                            ProcessStartInfo startInfo9 = new ProcessStartInfo();
                            ProcessStartInfo startInfo10 = new ProcessStartInfo();
                            ProcessStartInfo startInfo11 = new ProcessStartInfo();
                            ProcessStartInfo startInfo12 = new ProcessStartInfo();
                            astartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            astartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                            astartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo5.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo6.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo7.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo8.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo9.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo10.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo11.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo12.WindowStyle = ProcessWindowStyle.Hidden;
                            astartInfo.CreateNoWindow = true;
                            astartInfo2.CreateNoWindow = true;
                            astartInfo3.CreateNoWindow = true;
                            startInfo4.CreateNoWindow = true;
                            startInfo5.CreateNoWindow = true;
                            startInfo6.CreateNoWindow = true;
                            startInfo7.CreateNoWindow = true;
                            startInfo8.CreateNoWindow = true;
                            startInfo9.CreateNoWindow = true;
                            startInfo10.CreateNoWindow = true;
                            startInfo11.CreateNoWindow = true;
                            startInfo12.CreateNoWindow = true;
                            astartInfo.UseShellExecute = false;
                            astartInfo2.UseShellExecute = false;
                            astartInfo3.UseShellExecute = false;
                            startInfo4.UseShellExecute = false;
                            startInfo5.UseShellExecute = false;
                            startInfo6.UseShellExecute = false;
                            startInfo7.UseShellExecute = false;
                            startInfo8.UseShellExecute = false;
                            startInfo9.UseShellExecute = false;
                            startInfo10.UseShellExecute = false;
                            startInfo11.UseShellExecute = false;
                            startInfo11.UseShellExecute = false;
                            startInfo12.UseShellExecute = false;
                            astartInfo.RedirectStandardOutput = true;
                            astartInfo2.RedirectStandardOutput = true;
                            astartInfo3.RedirectStandardOutput = true;
                            startInfo4.RedirectStandardOutput = true;
                            startInfo5.RedirectStandardOutput = true;
                            startInfo6.RedirectStandardOutput = true;
                            startInfo7.RedirectStandardOutput = true;
                            startInfo8.RedirectStandardOutput = true;
                            startInfo9.RedirectStandardOutput = true;
                            startInfo10.RedirectStandardOutput = true;
                            startInfo11.RedirectStandardOutput = true;
                            startInfo12.RedirectStandardOutput = true;
                            astartInfo.FileName = "adb.exe";
                            astartInfo2.FileName = "adb.exe";
                            astartInfo3.FileName = "adb.exe";
                            startInfo4.FileName = "adb.exe";
                            startInfo5.FileName = "adb.exe";
                            startInfo6.FileName = "adb.exe";
                            startInfo7.FileName = "adb.exe";
                            startInfo8.FileName = "adb.exe";
                            startInfo9.FileName = "adb.exe";
                            startInfo10.FileName = "adb.exe";
                            startInfo11.FileName = "adb.exe";
                            startInfo12.FileName = "adb.exe";
                            astartInfo.Arguments = " shell getprop ro.product.model";
                            astartInfo2.Arguments = " shell getprop ro.product.manufacturer";
                            astartInfo3.Arguments = " shell getprop ro.build.version.release";
                            startInfo4.Arguments = " shell getprop ro.product.device";
                            startInfo5.Arguments = " shell getprop ro.product.brand";
                            startInfo6.Arguments = "shell getprop ro.build.id";
                            startInfo7.Arguments = "shell getprop ro.build.version.sdk";
                            startInfo8.Arguments = "shell getprop ro.build.version.codename";
                            startInfo9.Arguments = "shell getprop ro.build.version.all_codenames";
                            startInfo10.Arguments = "shell getprop ro.build.version.security_patch";
                            startInfo11.Arguments = "shell getprop ro.product.locale";
                            startInfo12.Arguments = " shell su -v ";
                            aprocess.StartInfo = astartInfo;
                            aprocess2.StartInfo = astartInfo2;
                            aprocess3.StartInfo = astartInfo3;
                            process4.StartInfo = startInfo4;
                            process5.StartInfo = startInfo5;
                            process6.StartInfo = startInfo6;
                            process7.StartInfo = startInfo7;
                            process8.StartInfo = startInfo8;
                            process9.StartInfo = startInfo9;
                            process10.StartInfo = startInfo10;
                            process11.StartInfo = startInfo11;
                            process12.StartInfo = startInfo12;
                            aprocess.Start();
                            aprocess2.Start();
                            aprocess3.Start();
                            process4.Start();
                            process5.Start();
                            process6.Start();
                            process7.Start();
                            process8.Start();
                            process9.Start();
                            process10.Start();
                            process11.Start();
                            process12.Start();
                            console.Text = console.Text + "Marka = " + aprocess2.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Model = " + aprocess.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Android Versiyon = " + aprocess3.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Kod Adı  = " + process4.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Üretici = " + process5.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Compilation Code = " + process6.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "SDK Numarası = " + process7.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Code Versiyon 1 = " + process8.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Code Versiyon 2 = " + process9.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Güvenlik Yaması Tarihi = " + process10.StandardOutput.ReadToEnd() + "\n";
                            console.Text = console.Text + "Dil ve Ülke = " + process11.StandardOutput.ReadToEnd() + "\n";
                            if (process12.StandardOutput.ReadToEnd() == "")
                            {
                                console.Text = console.Text + "Root  = " + "Root Bulunamadı" + "\n";
                            }
                            else
                            {
                                console.Text = console.Text + "Root  = " + process12.StandardOutput.ReadToEnd() + "\n";

                            }

                        }


                        if (label8.Text == "")
                        {
                            pictureBox1.BackColor = Color.Red;
                            label10.Text = "Cihaz Bağlı Değil";
                            label9.Visible = false;
                            label8.Visible = false;
                            label11.Visible = false;
                            label12.Visible = false;
                            label13.Visible = false;
                            if (label10.Text == "Cihaz Bağlı Değil")
                            {
                                Process process4 = new Process();
                                ProcessStartInfo startInfo4 = new ProcessStartInfo();
                                startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo4.CreateNoWindow = true;
                                startInfo4.UseShellExecute = false;
                                startInfo4.RedirectStandardOutput = true;
                                startInfo4.FileName = "fastboot.exe";
                                startInfo4.Arguments = "devices";
                                process.StartInfo = startInfo4;
                                process.Start();
                                label10.Text = process.StandardOutput.ReadToEnd();
                                console.Text = process.StandardOutput.ReadToEnd();
                                if (label10.Text == "")
                                {
                                    label9.Visible = false;
                                    label10.Text = "Cihaz Bağlı Değil";
                                }
                                else
                                {
                                    label9.Visible = true;
                                    pictureBox1.Visible = true;
                                    label10.Visible = true;
                                    pictureBox1.BackColor = Color.Aqua;

                                }

                            }
                        }
                        else
                        {
                            pictureBox1.BackColor = Color.Blue;
                            label8.Visible = true;
                            label9.Visible = true;
                            label10.Visible = true;
                            label11.Visible = true;
                            label12.Visible = true;
                            label13.Visible = true;

                        }
                    }
                }

            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.instagram.com/baris.mizrakli");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "reboot bootloader";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "reboot";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void tekseferlikCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if (tekseferlikCheckBox.Checked == true)
            {
                tekseferlikCheckBox.BackColor = Color.Green;
                kalıcıCheckBox.Enabled = false;
            }
            if (tekseferlikCheckBox.Checked == false)
            {
                tekseferlikCheckBox.BackColor = Color.Red;

                kalıcıCheckBox.Enabled = true;
            }
        }

        private void kalıcıCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (kalıcıCheckBox.Checked == true)
            {
                kalıcıCheckBox.BackColor = Color.Green;
                tekseferlikCheckBox.Enabled = false;
            }
            if (kalıcıCheckBox.Checked != true)
            {
                kalıcıCheckBox.BackColor = Color.Red;

                tekseferlikCheckBox.Enabled = true;
            }

        }

        private void MT67XX_CheckedChanged(object sender, EventArgs e)
        {
            if (MT65XX.Checked == true)
            {
                MT67XX.Enabled = false;
                Qualcomm.Enabled = false;
            }
            if (MT67XX.Checked == true)
            {
                MT65XX.Enabled = false;
                Qualcomm.Enabled = false;
            }
            if (Qualcomm.Checked == true)
            {
                MT67XX.Enabled = false;
                MT65XX.Enabled = false;
            }
        }

        private void Qualcomm_CheckedChanged(object sender, EventArgs e)
        {
            if (MT65XX.Checked == true)
            {
                MT67XX.Enabled = false;
                Qualcomm.Enabled = false;
            }
            if (MT67XX.Checked == true)
            {
                MT65XX.Enabled = false;
                Qualcomm.Enabled = false;
            }
            if (Qualcomm.Checked == true)
            {
                MT67XX.Enabled = false;
                MT65XX.Enabled = false;
            }
        }

        private void MT65XX_CheckedChanged(object sender, EventArgs e)
        {
            if (MT65XX.Checked == true)
            {
                MT67XX.Enabled = false;
                Qualcomm.Enabled = false;
            }
            if (MT67XX.Checked == true)
            {
                MT65XX.Enabled = false;
                Qualcomm.Enabled = false;
            }
            if (Qualcomm.Checked == true)
            {
                MT67XX.Enabled = false;
                MT65XX.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            recoveryoluTextBox.Text = "< Recovery Yolu >";
            MT65XX.Enabled = true;
            MT67XX.Enabled = true;
            tekseferlikCheckBox.Checked = false;
            kalıcıCheckBox.Checked = false;
            tekseferlikCheckBox.Enabled = true;
            kalıcıCheckBox.Enabled = true;
            Qualcomm.Enabled= true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gsmturkey.net");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                if (MT65XX.Checked == true || MT67XX.Checked == true || Qualcomm.Checked == true)
                {
                    if (tekseferlikCheckBox.Checked == true)
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo.CreateNoWindow = true;
                        startInfo.UseShellExecute = false;
                        startInfo.RedirectStandardOutput = true;
                        startInfo.FileName = "fastboot.exe";
                        startInfo.Arguments = "boot recovery.img";
                        process.StartInfo = startInfo;
                        process.Start();
                        console.Text = console.Text + process.StandardOutput.ReadToEnd();
                    }
                    if (kalıcıCheckBox.Checked == true)
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo.CreateNoWindow = true;
                        startInfo.UseShellExecute = false;
                        startInfo.RedirectStandardOutput = true;
                        startInfo.FileName = "fastboot.exe";
                        startInfo.Arguments = "flash recovery recovery.img";
                        process.StartInfo = startInfo;
                        process.Start();
                        console.Text = console.Text + process.StandardOutput.ReadToEnd();
                    }
                    if (pictureBox1.BackColor != Color.Aqua)
                    {
                        MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız", "Uyarı !");
                    }
                    else
                    {
                        MessageBox.Show("Kontrol Ediniz.","Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Seçimlerinizi Doğru Bir Şekilde Yapınız", "Uyarı !");
                }
            }


        }
        }
    }
