using System;
using System.Windows.Forms;

namespace InkForms
{
    public partial class AddNodeDialog : Form
    {
        byte _nodeType;
        string _name;
        public AddNodeDialog()
        {
            InitializeComponent();
            this.ActiveControl = tb_nodeName;
        }

        private void btn_nodeAdd_Click(object sender, EventArgs e)
        {
            _nodeType = cb_nodeType.SelectedIndex == -1? (byte)0 : (byte)cb_nodeType.SelectedIndex;
            _name = tb_nodeName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_nodeCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Byte Type
        {
            get => _nodeType;
        }

        public string NodeName
        {
            get => _name;
        }

        private void AddNodeDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_nodeAdd_Click(sender, new EventArgs());
                return;
            }
            if(e.KeyCode == Keys.Escape)
            {
                btn_nodeCancel_Click(sender, new EventArgs());
                return;
            }
        }
    }
}
