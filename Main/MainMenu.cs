using InkForms.Controls;
using InkForms.Elements;
using InkForms.Elements.Nodes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkForms
{
    public partial class Main : Form
    {
        private void item_file_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void item_file_new_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Create new scene?\nAll unsaved data will be lost!", "New Scene", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _root = new Root();
                Updatecanvas();
                UpdateTree();
            }
            else if (dialogResult == DialogResult.No)
                return;
        }

        private void item_file_saveas_Click(object sender, EventArgs e)
        {
            if (_root == null)
                return;
            string saveData = JsonConvert.SerializeObject(_root, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            DialogResult res = sf_diag.ShowDialog();
            if (res == DialogResult.OK)
                File.WriteAllText(sf_diag.FileName, saveData);
        }
        private void item_file_open_Click(object sender, EventArgs e)
        {
            DialogResult res = of_diag.ShowDialog();
            if (res == DialogResult.OK)
            {
                _root = JsonConvert.DeserializeObject<Root>(File.ReadAllText(of_diag.FileName), new JsonSerializerSettings 
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });
                Updatecanvas();
                UpdateTree();
            }
        }
        private void item_about_Click(object sender, EventArgs e)
        {
            About aboutWin = new About();
            aboutWin.ShowDialog();
        }
    }
}
