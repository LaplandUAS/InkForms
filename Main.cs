using InkForms.Controls;
using InkForms.Elements;
using InkForms.Elements.Nodes;
using InkForms.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
//brih
namespace InkForms
{
    public partial class Main : Form
    {
        private Root _root;
        public Node _selection;
        public Main()
        {
            InitializeComponent();
            InitializeCanvas();
        }

        private void AddItem(object sender, EventArgs e)
        {
            Node node;
            if (_root == null)
            {
                MessageBox.Show("No scene!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddNodeDialog dialog = new AddNodeDialog();
            dialog.StartPosition = FormStartPosition.CenterParent;
            var res = dialog.ShowDialog();
            if (res != DialogResult.OK)
                return;

            node = (Node)Activator.CreateInstance(Nodes.Types[dialog.Type + 1]);
            node.Name = dialog.NodeName;
            node.Type = (byte)(dialog.Type + 1);
            if(_selection != null)
                node.Parent = _selection.ID;

            if (node.Name == string.Empty)
                node.Name = node.GetType().Name + node.ID;

            if (_selection == null && node != null)
                _root.Children.Add(node);
            else
                _selection.AddChild(node);

            UpdateTree();
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            if (_selection == null)
            {
                MessageBox.Show("Select a child node to remove first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show($"Delete {_selection.Name}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                if (_selection.Parent == 0)
                {
                    _root.RemoveChild(_selection);
                    UpdateTree();
                    return;
                }
                Node parent = GetNodeByID(_root.Children, _selection.Parent);
                parent.RemoveChild(_selection);
                _selection = null;
                UpdateTree();
            }
            else if (dialogResult == DialogResult.No)
                return;
        }

        private void SelectItem(object sender, TreeViewEventArgs e)
        {
            gb_editor.Controls.Clear();
            if (tv_scene.SelectedNode.Tag != null)
            {
                _selection = GetNodeByID(_root.Children, (byte)uint.Parse(tv_scene.SelectedNode.Tag.ToString()));
                gb_editor.Text = _selection.Name;

                switch (_selection.Type)
                {
                    default:
                        //gb_editor.Text = "Node";
                        break;
                    case 1:                                 //Text node
                        //gb_editor.Text = "Text";
                        gb_editor.Controls.Add(new ucText(this));
                        break;
                    case 2:                                 //Symbol node
                        //gb_editor.Text = "Symbol";
                        break;
                    case 3:                                 //Element node
                        //gb_editor.Text = "Element";
                        break;
                }
            }
            else
            {
                //_selection = null;
                //gb_editor.Text = "Node";
                return;
            }
        }
        private void ItemMenu(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tv_scene.SelectedNode = e.Node;
                cm_editTree.Show(((TreeView)sender).PointToScreen(e.Location));
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Quit application?\nAll unsaved data will be lost!", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
