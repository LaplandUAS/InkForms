using InkForms.Elements.Nodes;
using System;
using System.Windows.Forms;

namespace InkForms.Controls
{
    public partial class ucText : UserControl
    {
        Main _mainForm;
        public ucText(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            Text _selectedObject = (Text)_mainForm._selection;
            cb_textFont.SelectedIndex = _selectedObject.Font;
            tb_textContent.Text = _selectedObject.Content;
        }

        private void tb_textContent_TextChanged(object sender, EventArgs e)
        {
            if (_mainForm == null)
                return;
            _mainForm._selection.UpdateContent((byte)cb_textFont.SelectedIndex, tb_textContent.Text);
        }
    }
}
