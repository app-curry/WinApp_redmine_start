using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp_redmine_start.Properties;

namespace WinApp_redmine_start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            init();
        }

        void init()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            textBox_redmine_installpath.AllowDrop = true;

            textBox_redmine_installpath.DragEnter += TextBox_redmine_installpath_DragEnter;
            textBox_redmine_installpath.DragDrop += TextBox_redmine_installpath_DragDrop;

            this.FormClosing += Form1_FormClosing;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.load();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.save();
        }

        private void TextBox_redmine_installpath_DragEnter(object sender, DragEventArgs e)
        {
            TextBox txbox = (TextBox)sender;

            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }

            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string path = paths[0];

            if (Directory.Exists(path))
            {
                e.Effect = DragDropEffects.Link;
            }
        }

        private void TextBox_redmine_installpath_DragDrop(object sender, DragEventArgs e)
        {
            TextBox txbox = (TextBox)sender;

            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string path = paths[0];

            txbox.Text = path;
        }
        void save()
        {
            Setting setting = new Setting();

            setting.RedmineInstallPath = textBox_redmine_installpath.Text;

            Setting.Save(setting);
        }
        void load()
        {
            Setting setting = Setting.Load();

            textBox_redmine_installpath.Text = setting.RedmineInstallPath;
        }

        private void button_redmine_start_Click(object sender, EventArgs e)
        {

            //string rmpath = @"C:\redmine-*.*.*\";
            string rmpath = textBox_redmine_installpath.Text;

            string cd = String.Format("cd {0}", rmpath);

            string rmexe = "bundle exec rails s -e production";

            List<string> cmdlist = new List<string>();

            cmdlist.Add(cd);
            cmdlist.Add(rmexe);

            string cmd = string.Join(Environment.NewLine, cmdlist);


            string path = string.Empty;

            path = Environment.CurrentDirectory;
            path = Path.Combine(path, "redmine_start.bat");


            // バッチファイル生成
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(cmd);
                sw.WriteLine("PAUSE");
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
            }

            // バッチファイル実行
            Process.Start(path);

        }
    }
}
