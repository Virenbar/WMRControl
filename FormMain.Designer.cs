
namespace WMRControl
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.B_State = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TrayControl = new System.Windows.Forms.NotifyIcon(this.components);
			this.CMS_Tray = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MI_Enable = new System.Windows.Forms.ToolStripMenuItem();
			this.MI_Disable = new System.Windows.Forms.ToolStripMenuItem();
			this.MI_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.TB_Name = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.TB_State = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.CMS_Tray.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// B_State
			// 
			this.B_State.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.B_State.Image = global::WMRControl.icons8.icons8_WMR_On_16;
			this.B_State.Location = new System.Drawing.Point(63, 12);
			this.B_State.Name = "B_State";
			this.B_State.Size = new System.Drawing.Size(127, 48);
			this.B_State.TabIndex = 0;
			this.B_State.Text = "Disable WMR";
			this.B_State.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.B_State.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.B_State.UseVisualStyleBackColor = true;
			this.B_State.Click += new System.EventHandler(this.B_State_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.B_State, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 141);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// TrayControl
			// 
			this.TrayControl.ContextMenuStrip = this.CMS_Tray;
			this.TrayControl.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayControl.Icon")));
			this.TrayControl.Visible = true;
			this.TrayControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayControl_MouseClick);
			// 
			// CMS_Tray
			// 
			this.CMS_Tray.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CMS_Tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Enable,
            this.MI_Disable,
            this.MI_Exit});
			this.CMS_Tray.Name = "CMS_Tray";
			this.CMS_Tray.Size = new System.Drawing.Size(181, 92);
			// 
			// MI_Enable
			// 
			this.MI_Enable.Image = global::WMRControl.icons8.icons8_WMR_On_16;
			this.MI_Enable.Name = "MI_Enable";
			this.MI_Enable.Size = new System.Drawing.Size(180, 22);
			this.MI_Enable.Text = "Enable WMR";
			this.MI_Enable.Click += new System.EventHandler(this.MI_Enable_Click);
			// 
			// MI_Disable
			// 
			this.MI_Disable.Image = global::WMRControl.icons8.icons8_WMR_Off_16;
			this.MI_Disable.Name = "MI_Disable";
			this.MI_Disable.Size = new System.Drawing.Size(180, 22);
			this.MI_Disable.Text = "Disable WMR";
			this.MI_Disable.Click += new System.EventHandler(this.MI_Disable_Click);
			// 
			// MI_Exit
			// 
			this.MI_Exit.Name = "MI_Exit";
			this.MI_Exit.Size = new System.Drawing.Size(180, 22);
			this.MI_Exit.Text = "Exit WMR Control";
			this.MI_Exit.Click += new System.EventHandler(this.MI_Exit_Click);
			// 
			// TB_Name
			// 
			this.TB_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_Name.Location = new System.Drawing.Point(53, 3);
			this.TB_Name.Name = "TB_Name";
			this.TB_Name.ReadOnly = true;
			this.TB_Name.Size = new System.Drawing.Size(192, 25);
			this.TB_Name.TabIndex = 6;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.TB_Name, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.TB_State, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 76);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(248, 62);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// TB_State
			// 
			this.TB_State.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_State.Location = new System.Drawing.Point(53, 34);
			this.TB_State.Name = "TB_State";
			this.TB_State.ReadOnly = true;
			this.TB_State.Size = new System.Drawing.Size(192, 25);
			this.TB_State.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 17);
			this.label1.TabIndex = 8;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "State";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(254, 141);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(270, 180);
			this.Name = "FormMain";
			this.Text = "WMR Control";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.CMS_Tray.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button B_State;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.NotifyIcon TrayControl;
		private System.Windows.Forms.ContextMenuStrip CMS_Tray;
		private System.Windows.Forms.ToolStripMenuItem MI_Enable;
		private System.Windows.Forms.ToolStripMenuItem MI_Disable;
		private System.Windows.Forms.ToolStripMenuItem MI_Exit;
		private System.Windows.Forms.TextBox TB_Name;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TB_State;
		private System.Windows.Forms.Label label1;
	}
}

