using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace TiffManipulator
{
	/// <summary>
	/// Summary description for Instructions.
	/// </summary>
	public class Instructions : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rtfInstructions;
		private System.Windows.Forms.CheckBox chkShowAtStartup;
		private System.Windows.Forms.Button btnClose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Instructions()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Instructions));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rtfInstructions = new System.Windows.Forms.RichTextBox();
			this.chkShowAtStartup = new System.Windows.Forms.CheckBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(28, 31);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(410, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tiff Manipulator Instructions";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rtfInstructions
			// 
			this.rtfInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.rtfInstructions.Location = new System.Drawing.Point(21, 55);
			this.rtfInstructions.Name = "rtfInstructions";
			this.rtfInstructions.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtfInstructions.Size = new System.Drawing.Size(480, 146);
			this.rtfInstructions.TabIndex = 2;
			this.rtfInstructions.Text = "";
			// 
			// chkShowAtStartup
			// 
			this.chkShowAtStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chkShowAtStartup.Checked = true;
			this.chkShowAtStartup.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkShowAtStartup.Location = new System.Drawing.Point(21, 216);
			this.chkShowAtStartup.Name = "chkShowAtStartup";
			this.chkShowAtStartup.Size = new System.Drawing.Size(109, 16);
			this.chkShowAtStartup.TabIndex = 3;
			this.chkShowAtStartup.Text = "Show at startup";
			this.chkShowAtStartup.CheckedChanged += new System.EventHandler(this.chkShowAtStartup_CheckedChanged);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnClose.Location = new System.Drawing.Point(422, 213);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(79, 25);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// Instructions
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(527, 249);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.chkShowAtStartup);
			this.Controls.Add(this.rtfInstructions);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(375, 275);
			this.Name = "Instructions";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Instructions";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Instructions_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void chkShowAtStartup_CheckedChanged(object sender, System.EventArgs e)
		{
			if (_loading) return;
			string settings = Application.UserAppDataPath + "\\TiffManipulatorSettings.txt";
			using (System.IO.FileStream writer = new System.IO.FileStream(settings, System.IO.FileMode.Create, System.IO.FileAccess.Write))
			{
				writer.WriteByte((byte)(this.chkShowAtStartup.Checked ? 1 : 0));
			}
		}

		private bool _loading;
		private void Instructions_Load(object sender, System.EventArgs e)
		{
			System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
			System.IO.Stream stream = asm.GetManifestResourceStream("TiffManipulator.Instructions.rtf");
			if (stream != null)
			{
				this.rtfInstructions.LoadFile(stream, RichTextBoxStreamType.RichText);
				stream.Close();
			}

			_loading = true;
			string settings = Application.UserAppDataPath + "\\TiffManipulatorSettings.txt";
			if (System.IO.File.Exists(settings))
			{
				using (System.IO.FileStream reader = new System.IO.FileStream(settings, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
				{
					this.chkShowAtStartup.Checked = (reader.ReadByte() == 1);
				}
			}
			_loading = false;
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
