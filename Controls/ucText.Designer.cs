namespace InkForms.Controls
{
    partial class ucText
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_textContent = new System.Windows.Forms.Label();
            this.tb_textContent = new System.Windows.Forms.TextBox();
            this.lb_textFont = new System.Windows.Forms.Label();
            this.cb_textFont = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_textContent
            // 
            this.lb_textContent.AutoSize = true;
            this.lb_textContent.Location = new System.Drawing.Point(3, 6);
            this.lb_textContent.Name = "lb_textContent";
            this.lb_textContent.Size = new System.Drawing.Size(36, 16);
            this.lb_textContent.TabIndex = 0;
            this.lb_textContent.Text = "Text:";
            // 
            // tb_textContent
            // 
            this.tb_textContent.Location = new System.Drawing.Point(45, 3);
            this.tb_textContent.Name = "tb_textContent";
            this.tb_textContent.Size = new System.Drawing.Size(245, 22);
            this.tb_textContent.TabIndex = 1;
            this.tb_textContent.TextChanged += new System.EventHandler(this.tb_textContent_TextChanged);
            // 
            // lb_textFont
            // 
            this.lb_textFont.AutoSize = true;
            this.lb_textFont.Location = new System.Drawing.Point(3, 33);
            this.lb_textFont.Name = "lb_textFont";
            this.lb_textFont.Size = new System.Drawing.Size(36, 16);
            this.lb_textFont.TabIndex = 2;
            this.lb_textFont.Text = "Font:";
            // 
            // cb_textFont
            // 
            this.cb_textFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_textFont.FormattingEnabled = true;
            this.cb_textFont.Items.AddRange(new object[] {
            "Default"});
            this.cb_textFont.Location = new System.Drawing.Point(45, 30);
            this.cb_textFont.Name = "cb_textFont";
            this.cb_textFont.Size = new System.Drawing.Size(101, 24);
            this.cb_textFont.TabIndex = 3;
            // 
            // ucText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_textFont);
            this.Controls.Add(this.lb_textFont);
            this.Controls.Add(this.tb_textContent);
            this.Controls.Add(this.lb_textContent);
            this.Location = new System.Drawing.Point(2, 16);
            this.Name = "ucText";
            this.Size = new System.Drawing.Size(293, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_textContent;
        private System.Windows.Forms.TextBox tb_textContent;
        private System.Windows.Forms.Label lb_textFont;
        private System.Windows.Forms.ComboBox cb_textFont;
    }
}
