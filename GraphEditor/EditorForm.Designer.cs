using System;
using System.Windows.Forms;

namespace GraphNodes
{
	partial class EditorForm
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
			Graph.Compatibility.AlwaysCompatible alwaysCompatible1 = new Graph.Compatibility.AlwaysCompatible();
			this.contextMenu = new ContextMenuStrip(this.components);
			this.graphControl = new Graph.GraphControl();
			this.treeView = new TreeView();
			this.contextMenu.SuspendLayout();
			// 
			// contextMenu
			// 

			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(150, 700);
			this.treeView.Location = new System.Drawing.Point(0, 24);
			this.treeView.Nodes.Clear();
			TreeNode root = new TreeNode();
			root.Text = "root";
			root.ExpandAll();
			this.treeView.Nodes.Add(root);
			this.treeView.ExpandAll();
			// 
			// contextMenu
			// 
			this.addNode = new System.Windows.Forms.ToolStripMenuItem();
			this.addNode.Name = "addNode";
			this.addNode.Size = new System.Drawing.Size(96, 22);
			this.addNode.Text = "addNode";

			this.delNode = new System.Windows.Forms.ToolStripMenuItem();
			this.delNode.Name = "delNode";
			this.delNode.Size = new System.Drawing.Size(96, 22);
			this.delNode.Text = "delNode";

			this.popupMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.popupMenu.Name = "PopupMenu";
			this.popupMenu.Size = new System.Drawing.Size(96, 22);
			this.popupMenu.Text = "Test";

			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.addNode,
			this.delNode,
			this.popupMenu
			});
			this.contextMenu.Name = "ContextMenu";
			this.contextMenu.Size = new System.Drawing.Size(97, 26);
			this.contextMenu.TabIndex = 0;

			// 
			// menuStrip
			// 

			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

			this.fileToolStripMenuItem_open = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem_save = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem_create = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.AllowMerge = false;
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.editToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(282, 28);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem_open,
			this.fileToolStripMenuItem_save,
			});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
			this.fileToolStripMenuItem.Text = "File";

			// 
			// fileToolStripMenuItem_open
			// 
			this.fileToolStripMenuItem_open.Name = "fileToolStripMenuItem_open";
			this.fileToolStripMenuItem_open.Size = new System.Drawing.Size(224, 26);
			this.fileToolStripMenuItem_open.Text = "open";
			this.fileToolStripMenuItem_open.Click += new System.EventHandler(this.fileToolStripMenuItem_open_Click);
			// 
			// fileToolStripMenuItem_save
			// 
			this.fileToolStripMenuItem_save.Name = "fileToolStripMenuItem_save";
			this.fileToolStripMenuItem_save.Size = new System.Drawing.Size(224, 26);
			this.fileToolStripMenuItem_save.Text = "save";
			this.fileToolStripMenuItem_save.Click += new System.EventHandler(this.fileToolStripMenuItem_save_Click);

			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.editToolStripMenuItem_create});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// editToolStripMenuItem_create
			// 
			this.editToolStripMenuItem_create.Name = "editToolStripMenuItem_create";
			this.editToolStripMenuItem_create.Size = new System.Drawing.Size(224, 26);
			this.editToolStripMenuItem_create.Text = "create";
			this.editToolStripMenuItem_create.Click += new System.EventHandler(this.editToolStripMenuItem_create_Click);

			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.aboutToolStripMenuItem.Text = "about";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// EditorForm
			// 
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "EditorForm";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

			// 
			// graphControl
			// 
			this.graphControl.AllowDrop = true;
			this.graphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.graphControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
			this.graphControl.CompatibilityStrategy = alwaysCompatible1;
			this.graphControl.FocusElement = null;
			this.graphControl.HighlightCompatible = true;
			this.graphControl.LargeGridStep = 128F;
			this.graphControl.LargeStepGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
			this.graphControl.Location = new System.Drawing.Point(150, 24);
			this.graphControl.Name = "graphControl";
			this.graphControl.ShowLabels = false;
			this.graphControl.Size = new System.Drawing.Size(1150, 700);
			this.graphControl.SmallGridStep = 16F;
			this.graphControl.SmallStepGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.graphControl.TabIndex = 0;
			this.graphControl.Text = "graphControl";
			// 
			// EditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1300, 550);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.treeView);
			this.Controls.Add(this.graphControl);
			this.DoubleBuffered = true;
			this.Name = "EditorForm";
			this.Text = "GraphEditor";
			this.contextMenu.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void fileToolStripMenuItem_open_Click(object sender, EventArgs e)
		{
			MessageBox.Show("open");
		}

		private void fileToolStripMenuItem_save_Click(object sender, EventArgs e)
		{
			MessageBox.Show("save");
		}

		private void editToolStripMenuItem_create_Click(object sender, EventArgs e)
		{
			MessageBox.Show("create");
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("about");
		}

		

		#endregion
		private Graph.GraphControl graphControl;
		private TreeView treeView;
		private ContextMenuStrip contextMenu;
		private ToolStripMenuItem addNode;
		private ToolStripMenuItem delNode;
		private ToolStripMenuItem popupMenu;

		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;

		private ToolStripMenuItem editToolStripMenuItem_create;
		private ToolStripMenuItem fileToolStripMenuItem_open;
		private ToolStripMenuItem fileToolStripMenuItem_save;

		private ToolStripMenuItem aboutToolStripMenuItem;
	}
}

