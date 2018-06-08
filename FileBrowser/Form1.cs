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

namespace FileBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "TEST";

            string initialFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OpenFolder(initialFolder);
        }

        private void OpenFolder(string initialFolder)
        {
            string[] dirs = Directory.GetDirectories(initialFolder);
            foreach (string dir in dirs)
            {
                string[] subitems = new string[] { Path.GetFileName(dir), "フォルダ" };
                ListViewItem item = new ListViewItem(subitems);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
