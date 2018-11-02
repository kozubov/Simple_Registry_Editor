using Microsoft.Win32;
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

namespace SP_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_Remove.Enabled = false;
            LoadRegistry();
            listBox_AutoRun.SelectedIndexChanged += ListBox_AutoRun_SelectedIndexChanged;
            button_Add.Click += Button_Add_Click;
            button_Remove.Click += Button_Remove_Click;
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            RegistryKey curUser = Registry.CurrentUser;
            RegistryKey key = curUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            key.DeleteValue(listBox_AutoRun.SelectedItem.ToString());
            key.Close();
            curUser.Close();
            listBox_AutoRun.Items.Clear();
            LoadRegistry();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                AddProgramm();
            }
        }

        private void AddProgramm()
        {
            RegistryKey curUser = Registry.CurrentUser;
            RegistryKey key = curUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            string str = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            key.SetValue(str, openFileDialog.FileName);
            key.Close();
            curUser.Close();
            listBox_AutoRun.Items.Clear();
            LoadRegistry();

        }

        private void ListBox_AutoRun_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Remove.Enabled = (listBox_AutoRun.SelectedItems.Count > 0);
        }

        private void LoadRegistry()
        {
            RegistryKey curUser = Registry.CurrentUser;
            RegistryKey key = curUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            foreach (var item in key.GetValueNames())
            {
                listBox_AutoRun.Items.Add(item);
            }

        }
    }
}
