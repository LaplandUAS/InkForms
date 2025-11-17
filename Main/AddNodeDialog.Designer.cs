namespace InkForms
{
    partial class AddNodeDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_nodeType = new System.Windows.Forms.ComboBox();
            this.lb_nodeType = new System.Windows.Forms.Label();
            this.lb_nodeName = new System.Windows.Forms.Label();
            this.tb_nodeName = new System.Windows.Forms.TextBox();
            this.gb_attributes = new System.Windows.Forms.GroupBox();
            this.btn_nodeAdd = new System.Windows.Forms.Button();
            this.btn_nodeCancel = new System.Windows.Forms.Button();
            this.gb_attributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_nodeType
            // 
            this.cb_nodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nodeType.FormattingEnabled = true;
            this.cb_nodeType.Items.AddRange(new object[] {
            "Text",
            "Symbol",
            "Element"});
            this.cb_nodeType.Location = new System.Drawing.Point(61, 49);
            this.cb_nodeType.Name = "cb_nodeType";
            this.cb_nodeType.Size = new System.Drawing.Size(120, 24);
            this.cb_nodeType.TabIndex = 0;
            // 
            // lb_nodeType
            // 
            this.lb_nodeType.AutoSize = true;
            this.lb_nodeType.Location = new System.Drawing.Point(13, 52);
            this.lb_nodeType.Name = "lb_nodeType";
            this.lb_nodeType.Size = new System.Drawing.Size(42, 16);
            this.lb_nodeType.TabIndex = 1;
            this.lb_nodeType.Text = "Type:";
            // 
            // lb_nodeName
            // 
            this.lb_nodeName.AutoSize = true;
            this.lb_nodeName.Location = new System.Drawing.Point(8, 24);
            this.lb_nodeName.Name = "lb_nodeName";
            this.lb_nodeName.Size = new System.Drawing.Size(47, 16);
            this.lb_nodeName.TabIndex = 2;
            this.lb_nodeName.Text = "Name:";
            // 
            // tb_nodeName
            // 
            this.tb_nodeName.Location = new System.Drawing.Point(61, 21);
            this.tb_nodeName.Name = "tb_nodeName";
            this.tb_nodeName.Size = new System.Drawing.Size(120, 22);
            this.tb_nodeName.TabIndex = 3;
            // 
            // gb_attributes
            // 
            this.gb_attributes.Controls.Add(this.cb_nodeType);
            this.gb_attributes.Controls.Add(this.tb_nodeName);
            this.gb_attributes.Controls.Add(this.lb_nodeType);
            this.gb_attributes.Controls.Add(this.lb_nodeName);
            this.gb_attributes.Location = new System.Drawing.Point(12, 12);
            this.gb_attributes.Name = "gb_attributes";
            this.gb_attributes.Size = new System.Drawing.Size(203, 91);
            this.gb_attributes.TabIndex = 4;
            this.gb_attributes.TabStop = false;
            this.gb_attributes.Text = "Attributes";
            // 
            // btn_nodeAdd
            // 
            this.btn_nodeAdd.Location = new System.Drawing.Point(12, 109);
            this.btn_nodeAdd.Name = "btn_nodeAdd";
            this.btn_nodeAdd.Size = new System.Drawing.Size(79, 34);
            this.btn_nodeAdd.TabIndex = 5;
            this.btn_nodeAdd.Text = "Ok";
            this.btn_nodeAdd.UseVisualStyleBackColor = true;
            this.btn_nodeAdd.Click += new System.EventHandler(this.btn_nodeAdd_Click);
            // 
            // btn_nodeCancel
            // 
            this.btn_nodeCancel.Location = new System.Drawing.Point(136, 109);
            this.btn_nodeCancel.Name = "btn_nodeCancel";
            this.btn_nodeCancel.Size = new System.Drawing.Size(79, 34);
            this.btn_nodeCancel.TabIndex = 6;
            this.btn_nodeCancel.Text = "Cancel";
            this.btn_nodeCancel.UseVisualStyleBackColor = true;
            this.btn_nodeCancel.Click += new System.EventHandler(this.btn_nodeCancel_Click);
            // 
            // AddNodeDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(227, 155);
            this.Controls.Add(this.btn_nodeCancel);
            this.Controls.Add(this.btn_nodeAdd);
            this.Controls.Add(this.gb_attributes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "AddNodeDialog";
            this.Text = "Add Node";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddNodeDialog_KeyDown);
            this.gb_attributes.ResumeLayout(false);
            this.gb_attributes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nodeType;
        private System.Windows.Forms.Label lb_nodeType;
        private System.Windows.Forms.Label lb_nodeName;
        private System.Windows.Forms.TextBox tb_nodeName;
        private System.Windows.Forms.GroupBox gb_attributes;
        private System.Windows.Forms.Button btn_nodeAdd;
        private System.Windows.Forms.Button btn_nodeCancel;
    }
}