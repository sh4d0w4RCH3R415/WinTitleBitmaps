
namespace Demo
{
	partial class Form1
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
			this.picClose = new System.Windows.Forms.PictureBox();
			this.picMaximize = new System.Windows.Forms.PictureBox();
			this.picMinimize = new System.Windows.Forms.PictureBox();
			this.picRestore = new System.Windows.Forms.PictureBox();
			this.picHelp = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRestore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
			this.SuspendLayout();
			// 
			// picClose
			// 
			this.picClose.BackColor = System.Drawing.SystemColors.ControlLight;
			this.picClose.Location = new System.Drawing.Point(195, 165);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(32, 32);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picClose.TabIndex = 0;
			this.picClose.TabStop = false;
			// 
			// picMaximize
			// 
			this.picMaximize.BackColor = System.Drawing.SystemColors.ControlLight;
			this.picMaximize.Location = new System.Drawing.Point(233, 165);
			this.picMaximize.Name = "picMaximize";
			this.picMaximize.Size = new System.Drawing.Size(32, 32);
			this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picMaximize.TabIndex = 1;
			this.picMaximize.TabStop = false;
			// 
			// picMinimize
			// 
			this.picMinimize.BackColor = System.Drawing.SystemColors.ControlLight;
			this.picMinimize.Location = new System.Drawing.Point(271, 165);
			this.picMinimize.Name = "picMinimize";
			this.picMinimize.Size = new System.Drawing.Size(32, 32);
			this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picMinimize.TabIndex = 2;
			this.picMinimize.TabStop = false;
			// 
			// picRestore
			// 
			this.picRestore.BackColor = System.Drawing.SystemColors.ControlLight;
			this.picRestore.Location = new System.Drawing.Point(309, 165);
			this.picRestore.Name = "picRestore";
			this.picRestore.Size = new System.Drawing.Size(32, 32);
			this.picRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picRestore.TabIndex = 3;
			this.picRestore.TabStop = false;
			// 
			// picHelp
			// 
			this.picHelp.BackColor = System.Drawing.SystemColors.ControlLight;
			this.picHelp.Location = new System.Drawing.Point(347, 165);
			this.picHelp.Name = "picHelp";
			this.picHelp.Size = new System.Drawing.Size(32, 32);
			this.picHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picHelp.TabIndex = 4;
			this.picHelp.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(579, 349);
			this.Controls.Add(this.picHelp);
			this.Controls.Add(this.picRestore);
			this.Controls.Add(this.picMinimize);
			this.Controls.Add(this.picMaximize);
			this.Controls.Add(this.picClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Demo";
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRestore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.PictureBox picMaximize;
		private System.Windows.Forms.PictureBox picMinimize;
		private System.Windows.Forms.PictureBox picRestore;
		private System.Windows.Forms.PictureBox picHelp;
	}
}

