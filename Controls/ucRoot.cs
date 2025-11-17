using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkForms.Controls
{
    public partial class ucRoot : UserControl
    {
        public ucRoot()
        {
            InitializeComponent();
        }
        public byte Orientation
        {
            get=>(byte)cb_rootOrientation.SelectedIndex;
        }
    }
}
