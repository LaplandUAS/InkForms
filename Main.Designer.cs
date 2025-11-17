namespace InkForms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tv_scene = new System.Windows.Forms.TreeView();
            this.il_nodeIcons = new System.Windows.Forms.ImageList(this.components);
            this.ms_top = new System.Windows.Forms.MenuStrip();
            this.item_file = new System.Windows.Forms.ToolStripMenuItem();
            this.item_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.item_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.item_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.item_file_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.item_file_s0 = new System.Windows.Forms.ToolStripSeparator();
            this.item_file_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.item_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.item_edit_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.item_edit_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.item_edit_s0 = new System.Windows.Forms.ToolStripSeparator();
            this.item_about = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_sceneTree = new System.Windows.Forms.GroupBox();
            this.gb_sceneView = new System.Windows.Forms.GroupBox();
            this.gb_editor = new System.Windows.Forms.GroupBox();
            this.pb_sceneBuffer = new System.Windows.Forms.PictureBox();
            this.cm_editTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ts_itemAddNode = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_itemRemoveNode = new System.Windows.Forms.ToolStripMenuItem();
            this.sf_diag = new System.Windows.Forms.SaveFileDialog();
            this.of_diag = new System.Windows.Forms.OpenFileDialog();
            this.addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_top.SuspendLayout();
            this.gb_sceneTree.SuspendLayout();
            this.gb_sceneView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sceneBuffer)).BeginInit();
            this.cm_editTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_scene
            // 
            this.tv_scene.HideSelection = false;
            this.tv_scene.ImageIndex = 0;
            this.tv_scene.ImageList = this.il_nodeIcons;
            this.tv_scene.Location = new System.Drawing.Point(6, 21);
            this.tv_scene.Name = "tv_scene";
            this.tv_scene.SelectedImageIndex = 0;
            this.tv_scene.Size = new System.Drawing.Size(245, 395);
            this.tv_scene.TabIndex = 0;
            this.tv_scene.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectItem);
            this.tv_scene.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ItemMenu);
            // 
            // il_nodeIcons
            // 
            this.il_nodeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_nodeIcons.ImageStream")));
            this.il_nodeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.il_nodeIcons.Images.SetKeyName(0, "t_nodeRoot.png");
            this.il_nodeIcons.Images.SetKeyName(1, "t_nodeText.png");
            this.il_nodeIcons.Images.SetKeyName(2, "t_nodeSymbol.png");
            this.il_nodeIcons.Images.SetKeyName(3, "t_nodeElement.png");
            // 
            // ms_top
            // 
            this.ms_top.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_file,
            this.item_edit,
            this.item_about});
            this.ms_top.Location = new System.Drawing.Point(0, 0);
            this.ms_top.Name = "ms_top";
            this.ms_top.Size = new System.Drawing.Size(814, 30);
            this.ms_top.TabIndex = 1;
            this.ms_top.Text = "Menu";
            // 
            // item_file
            // 
            this.item_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_file_new,
            this.item_file_open,
            this.item_file_save,
            this.item_file_saveas,
            this.item_file_s0,
            this.item_file_quit});
            this.item_file.Name = "item_file";
            this.item_file.Size = new System.Drawing.Size(46, 26);
            this.item_file.Text = "File";
            // 
            // item_file_new
            // 
            this.item_file_new.Name = "item_file_new";
            this.item_file_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.item_file_new.Size = new System.Drawing.Size(224, 26);
            this.item_file_new.Text = "New";
            this.item_file_new.ToolTipText = "New Scene.";
            this.item_file_new.Click += new System.EventHandler(this.item_file_new_Click);
            // 
            // item_file_open
            // 
            this.item_file_open.Name = "item_file_open";
            this.item_file_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.item_file_open.Size = new System.Drawing.Size(224, 26);
            this.item_file_open.Text = "Open...";
            this.item_file_open.ToolTipText = "Open Scene.";
            this.item_file_open.Click += new System.EventHandler(this.item_file_open_Click);
            // 
            // item_file_save
            // 
            this.item_file_save.Name = "item_file_save";
            this.item_file_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.item_file_save.Size = new System.Drawing.Size(224, 26);
            this.item_file_save.Text = "Save...";
            this.item_file_save.ToolTipText = "Save Scene.";
            // 
            // item_file_saveas
            // 
            this.item_file_saveas.Name = "item_file_saveas";
            this.item_file_saveas.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.item_file_saveas.Size = new System.Drawing.Size(224, 26);
            this.item_file_saveas.Text = "SaveAs";
            this.item_file_saveas.ToolTipText = "Save Scene as.";
            this.item_file_saveas.Click += new System.EventHandler(this.item_file_saveas_Click);
            // 
            // item_file_s0
            // 
            this.item_file_s0.Name = "item_file_s0";
            this.item_file_s0.Size = new System.Drawing.Size(215, 6);
            // 
            // item_file_quit
            // 
            this.item_file_quit.Name = "item_file_quit";
            this.item_file_quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.item_file_quit.Size = new System.Drawing.Size(224, 26);
            this.item_file_quit.Text = "Exit";
            this.item_file_quit.ToolTipText = "Quit application.";
            this.item_file_quit.Click += new System.EventHandler(this.item_file_quit_Click);
            // 
            // item_edit
            // 
            this.item_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_edit_undo,
            this.item_edit_redo,
            this.item_edit_s0,
            this.addNodeToolStripMenuItem,
            this.removeNodeToolStripMenuItem});
            this.item_edit.Name = "item_edit";
            this.item_edit.Size = new System.Drawing.Size(49, 26);
            this.item_edit.Text = "Edit";
            // 
            // item_edit_undo
            // 
            this.item_edit_undo.Enabled = false;
            this.item_edit_undo.Name = "item_edit_undo";
            this.item_edit_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.item_edit_undo.Size = new System.Drawing.Size(179, 26);
            this.item_edit_undo.Text = "Undo";
            // 
            // item_edit_redo
            // 
            this.item_edit_redo.Enabled = false;
            this.item_edit_redo.Name = "item_edit_redo";
            this.item_edit_redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.item_edit_redo.Size = new System.Drawing.Size(179, 26);
            this.item_edit_redo.Text = "Redo";
            // 
            // item_edit_s0
            // 
            this.item_edit_s0.Name = "item_edit_s0";
            this.item_edit_s0.Size = new System.Drawing.Size(176, 6);
            // 
            // item_about
            // 
            this.item_about.Name = "item_about";
            this.item_about.Size = new System.Drawing.Size(64, 26);
            this.item_about.Text = "About";
            this.item_about.Click += new System.EventHandler(this.item_about_Click);
            // 
            // gb_sceneTree
            // 
            this.gb_sceneTree.Controls.Add(this.tv_scene);
            this.gb_sceneTree.Location = new System.Drawing.Point(12, 31);
            this.gb_sceneTree.Name = "gb_sceneTree";
            this.gb_sceneTree.Size = new System.Drawing.Size(258, 422);
            this.gb_sceneTree.TabIndex = 2;
            this.gb_sceneTree.TabStop = false;
            this.gb_sceneTree.Text = "Scene Tree";
            // 
            // gb_sceneView
            // 
            this.gb_sceneView.Controls.Add(this.gb_editor);
            this.gb_sceneView.Controls.Add(this.pb_sceneBuffer);
            this.gb_sceneView.Location = new System.Drawing.Point(276, 31);
            this.gb_sceneView.Name = "gb_sceneView";
            this.gb_sceneView.Size = new System.Drawing.Size(412, 422);
            this.gb_sceneView.TabIndex = 3;
            this.gb_sceneView.TabStop = false;
            this.gb_sceneView.Text = "Preview";
            // 
            // gb_editor
            // 
            this.gb_editor.Location = new System.Drawing.Point(6, 327);
            this.gb_editor.Name = "gb_editor";
            this.gb_editor.Size = new System.Drawing.Size(400, 89);
            this.gb_editor.TabIndex = 1;
            this.gb_editor.TabStop = false;
            this.gb_editor.Text = "Node";
            // 
            // pb_sceneBuffer
            // 
            this.pb_sceneBuffer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_sceneBuffer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pb_sceneBuffer.Location = new System.Drawing.Point(6, 21);
            this.pb_sceneBuffer.Name = "pb_sceneBuffer";
            this.pb_sceneBuffer.Size = new System.Drawing.Size(400, 300);
            this.pb_sceneBuffer.TabIndex = 0;
            this.pb_sceneBuffer.TabStop = false;
            this.pb_sceneBuffer.MouseLeave += new System.EventHandler(this.pb_sceneBuffer_MouseLeave);
            this.pb_sceneBuffer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_sceneBuffer_MouseMove);
            // 
            // cm_editTree
            // 
            this.cm_editTree.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cm_editTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_itemAddNode,
            this.ts_itemRemoveNode});
            this.cm_editTree.Name = "cm_editTree";
            this.cm_editTree.Size = new System.Drawing.Size(142, 52);
            // 
            // ts_itemAddNode
            // 
            this.ts_itemAddNode.Name = "ts_itemAddNode";
            this.ts_itemAddNode.Size = new System.Drawing.Size(141, 24);
            this.ts_itemAddNode.Text = "Add..";
            this.ts_itemAddNode.Click += new System.EventHandler(this.AddItem);
            // 
            // ts_itemRemoveNode
            // 
            this.ts_itemRemoveNode.Name = "ts_itemRemoveNode";
            this.ts_itemRemoveNode.Size = new System.Drawing.Size(141, 24);
            this.ts_itemRemoveNode.Text = "Remove...";
            this.ts_itemRemoveNode.Click += new System.EventHandler(this.RemoveItem);
            // 
            // sf_diag
            // 
            this.sf_diag.DefaultExt = "json";
            this.sf_diag.FileName = "Scene";
            // 
            // of_diag
            // 
            this.of_diag.DefaultExt = "json";
            // 
            // addNodeToolStripMenuItem
            // 
            this.addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            this.addNodeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.addNodeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNodeToolStripMenuItem.Text = "Add Node";
            this.addNodeToolStripMenuItem.ToolTipText = "Add a new child Node.";
            this.addNodeToolStripMenuItem.Click += new System.EventHandler(this.AddItem);
            // 
            // removeNodeToolStripMenuItem
            // 
            this.removeNodeToolStripMenuItem.Name = "removeNodeToolStripMenuItem";
            this.removeNodeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeNodeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeNodeToolStripMenuItem.Text = "Remove Node";
            this.removeNodeToolStripMenuItem.ToolTipText = "Delete selected Node.";
            this.removeNodeToolStripMenuItem.Click += new System.EventHandler(this.RemoveItem);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(814, 465);
            this.Controls.Add(this.gb_sceneView);
            this.Controls.Add(this.gb_sceneTree);
            this.Controls.Add(this.ms_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.ms_top;
            this.Name = "Main";
            this.Text = "Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ms_top.ResumeLayout(false);
            this.ms_top.PerformLayout();
            this.gb_sceneTree.ResumeLayout(false);
            this.gb_sceneView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_sceneBuffer)).EndInit();
            this.cm_editTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_scene;
        private System.Windows.Forms.MenuStrip ms_top;
        private System.Windows.Forms.ToolStripMenuItem item_file;
        private System.Windows.Forms.ToolStripMenuItem item_edit;
        private System.Windows.Forms.ToolStripMenuItem item_file_new;
        private System.Windows.Forms.ToolStripMenuItem item_file_open;
        private System.Windows.Forms.ToolStripMenuItem item_file_save;
        private System.Windows.Forms.ToolStripMenuItem item_file_saveas;
        private System.Windows.Forms.ToolStripSeparator item_file_s0;
        private System.Windows.Forms.ToolStripMenuItem item_file_quit;
        private System.Windows.Forms.ToolStripMenuItem item_edit_undo;
        private System.Windows.Forms.ToolStripMenuItem item_edit_redo;
        private System.Windows.Forms.ToolStripSeparator item_edit_s0;
        private System.Windows.Forms.ToolStripMenuItem item_about;
        private System.Windows.Forms.GroupBox gb_sceneTree;
        private System.Windows.Forms.ImageList il_nodeIcons;
        private System.Windows.Forms.GroupBox gb_sceneView;
        private System.Windows.Forms.PictureBox pb_sceneBuffer;
        private System.Windows.Forms.ContextMenuStrip cm_editTree;
        private System.Windows.Forms.ToolStripMenuItem ts_itemAddNode;
        private System.Windows.Forms.ToolStripMenuItem ts_itemRemoveNode;
        private System.Windows.Forms.SaveFileDialog sf_diag;
        private System.Windows.Forms.OpenFileDialog of_diag;
        private System.Windows.Forms.GroupBox gb_editor;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNodeToolStripMenuItem;
    }
}

