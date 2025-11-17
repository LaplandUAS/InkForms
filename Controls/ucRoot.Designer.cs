namespace InkForms.Controls
{
    partial class ucRoot
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
            this.lb_rootOrientation = new System.Windows.Forms.Label();
            this.cb_rootOrientation = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lb_rootOrientation
            // 
            this.lb_rootOrientation.AutoSize = true;
            this.lb_rootOrientation.Location = new System.Drawing.Point(3, 6);
            this.lb_rootOrientation.Name = "lb_rootOrientation";
            this.lb_rootOrientation.Size = new System.Drawing.Size(74, 16);
            this.lb_rootOrientation.TabIndex = 0;
            this.lb_rootOrientation.Text = "Orientation:";
            // 
            // cb_rootOrientation
            // 
            this.cb_rootOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rootOrientation.FormattingEnabled = true;
            this.cb_rootOrientation.Items.AddRange(new object[] {
            "0°",
            "90°",
            "180°",
            "270°"});
            this.cb_rootOrientation.Location = new System.Drawing.Point(83, 3);
            this.cb_rootOrientation.Name = "cb_rootOrientation";
            this.cb_rootOrientation.Size = new System.Drawing.Size(121, 24);
            this.cb_rootOrientation.TabIndex = 1;
            // 
            // ucRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb_rootOrientation);
            this.Controls.Add(this.lb_rootOrientation);
            this.Location = new System.Drawing.Point(2, 16);
            this.Name = "ucRoot";
            this.Size = new System.Drawing.Size(214, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_rootOrientation;
        private System.Windows.Forms.ComboBox cb_rootOrientation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
