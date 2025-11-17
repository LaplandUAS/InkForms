using InkForms.Elements;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InkForms
{
    public partial class Main : Form
    {
        private void UpdateTree()
        {
            tv_scene.BeginUpdate();
            tv_scene.Nodes.Clear();
            tv_scene.Nodes.Add("Scene");
            if (_root.Children.Count != 0)
            {
                AddTreeItem(_root, tv_scene.Nodes[0]);
            }
            tv_scene.ExpandAll();
            tv_scene.EndUpdate();
        }
        private void AddTreeItem(Node node, TreeNode parent)
        {

            foreach (Node n in node.Children)
            {
                TreeNode tn = new TreeNode(n.Name);
                tn.Tag = n.ID;
                tn.ImageIndex = n.Type;
                tn.SelectedImageIndex = n.Type;
                if (n.Children.Count != 0)
                {
                    AddTreeItem(n, tn);
                }
                parent.Nodes.Add(tn);
            }
            return;
        }
        private Node GetNodeByID(List<Node> nodes, byte? id)
        {
            foreach (Node n in nodes)
            {
                if (n.ID == id)
                    return n;

                if (n.Children.Count != 0)
                {
                    Node result = GetNodeByID(n.Children, id);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }
    }
}
