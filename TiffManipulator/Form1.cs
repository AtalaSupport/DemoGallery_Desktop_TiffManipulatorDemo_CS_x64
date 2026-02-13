using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Atalasoft.Imaging;
using Atalasoft.Imaging.Codec;
using Atalasoft.Imaging.Codec.Tiff;
using Atalasoft.Imaging.WinControls;

namespace TiffManipulator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;

		private string _currentFile = null;
		private Form _instructionForm;
		private System.Windows.Forms.MenuItem saveItem;
		private System.Windows.Forms.MenuItem quitItem;
		private System.Windows.Forms.MenuItem addFileItem;
		private System.Windows.Forms.ListBox fileList;
		private Atalasoft.Imaging.WinControls.ThumbnailView thumbnailView1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuAbout;
		private System.Windows.Forms.Panel panelBanner;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.LinkLabel linkHomePage;
		private System.Windows.Forms.Panel panelEdge;
		private System.Windows.Forms.MenuItem menuItem2;

		private System.ComponentModel.Container components = null;

		public Form1()
		{
			Splash frm = new Splash();
			frm.Show();

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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.addFileItem = new System.Windows.Forms.MenuItem();
			this.saveItem = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.quitItem = new System.Windows.Forms.MenuItem();
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.menuAbout = new System.Windows.Forms.MenuItem();
			this.fileList = new System.Windows.Forms.ListBox();
			this.thumbnailView1 = new Atalasoft.Imaging.WinControls.ThumbnailView();
			this.panelBanner = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.linkHomePage = new System.Windows.Forms.LinkLabel();
			this.panelEdge = new System.Windows.Forms.Panel();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.panelBanner.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuHelp});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.addFileItem,
																					  this.saveItem,
																					  this.menuItem4,
																					  this.quitItem});
			this.menuItem1.Text = "&File";
			// 
			// addFileItem
			// 
			this.addFileItem.Index = 0;
			this.addFileItem.Text = "&Add File...";
			this.addFileItem.Click += new System.EventHandler(this.addFileItem_Click);
			// 
			// saveItem
			// 
			this.saveItem.Index = 1;
			this.saveItem.Text = "&Save As...";
			this.saveItem.Click += new System.EventHandler(this.saveItem_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "-";
			// 
			// quitItem
			// 
			this.quitItem.Index = 3;
			this.quitItem.Text = "&Quit";
			this.quitItem.Click += new System.EventHandler(this.quitItem_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.Index = 1;
			this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuItem2,
																					 this.menuAbout});
			this.menuHelp.Text = "&Help";
			// 
			// menuAbout
			// 
			this.menuAbout.Index = 1;
			this.menuAbout.Text = "&About...";
			this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
			// 
			// fileList
			// 
			this.fileList.Dock = System.Windows.Forms.DockStyle.Right;
			this.fileList.IntegralHeight = false;
			this.fileList.Location = new System.Drawing.Point(400, 43);
			this.fileList.Name = "fileList";
			this.fileList.Size = new System.Drawing.Size(208, 438);
			this.fileList.TabIndex = 1;
			this.fileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileList_KeyDown);
			// 
			// thumbnailView1
			// 
			this.thumbnailView1.AutoDragDrop = true;
			this.thumbnailView1.BackColor = System.Drawing.SystemColors.Window;
			this.thumbnailView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.thumbnailView1.DragSelectionColor = System.Drawing.Color.Red;
			this.thumbnailView1.DropPositionIndicator = Atalasoft.Imaging.WinControls.ThumbnailDropPositionIndicator.IBeam;
			this.thumbnailView1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.thumbnailView1.HighlightBackgroundColor = System.Drawing.SystemColors.Highlight;
			this.thumbnailView1.HighlightTextColor = System.Drawing.SystemColors.HighlightText;
			this.thumbnailView1.LoadErrorMessage = "";
			this.thumbnailView1.Location = new System.Drawing.Point(0, 43);
			this.thumbnailView1.Margins = new Atalasoft.Imaging.WinControls.Margin(4, 4, 4, 4);
			this.thumbnailView1.Name = "thumbnailView1";
			this.thumbnailView1.SelectionRectangleBackColor = System.Drawing.Color.Transparent;
			this.thumbnailView1.SelectionRectangleDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
			this.thumbnailView1.SelectionRectangleLineColor = System.Drawing.Color.Black;
			this.thumbnailView1.Size = new System.Drawing.Size(400, 438);
			this.thumbnailView1.TabIndex = 0;
			this.thumbnailView1.Text = "thumbnailView1";
			this.thumbnailView1.ThumbnailBackground = null;
			this.thumbnailView1.ThumbnailOffset = new System.Drawing.Point(0, 0);
			this.thumbnailView1.ThumbnailSize = new System.Drawing.Size(100, 100);
			this.thumbnailView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.thumbnailView1_KeyDown);
			// 
			// panelBanner
			// 
			this.panelBanner.BackColor = System.Drawing.Color.White;
			this.panelBanner.Controls.Add(this.linkHomePage);
			this.panelBanner.Controls.Add(this.pictureBox2);
			this.panelBanner.Controls.Add(this.pictureBox1);
			this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBanner.Location = new System.Drawing.Point(0, 0);
			this.panelBanner.Name = "panelBanner";
			this.panelBanner.Size = new System.Drawing.Size(608, 40);
			this.panelBanner.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, -8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 48);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(68, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(144, 40);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// linkHomePage
			// 
			this.linkHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkHomePage.Location = new System.Drawing.Point(470, 13);
			this.linkHomePage.Name = "linkHomePage";
			this.linkHomePage.Size = new System.Drawing.Size(128, 16);
			this.linkHomePage.TabIndex = 2;
			this.linkHomePage.TabStop = true;
			this.linkHomePage.Text = "http://www.atalasoft.com";
			this.linkHomePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHomePage_LinkClicked);
			// 
			// panelEdge
			// 
			this.panelEdge.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelEdge.Location = new System.Drawing.Point(0, 40);
			this.panelEdge.Name = "panelEdge";
			this.panelEdge.Size = new System.Drawing.Size(608, 3);
			this.panelEdge.TabIndex = 3;
			this.panelEdge.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEdge_Paint);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&Instructions";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(608, 481);
			this.Controls.Add(this.thumbnailView1);
			this.Controls.Add(this.fileList);
			this.Controls.Add(this.panelEdge);
			this.Controls.Add(this.panelBanner);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(350, 250);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atalasoft Tiff Manipulator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelBanner.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new Form1());
		}

		private void addFileItem_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "TIFF Images (*.tif)|*.tif";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				if (CanOpenThisFileAsTiff(ofd.FileName)) 
				{
					if (AlreadyAddedFile(ofd.FileName)) 
					{
						MessageBox.Show("This file is already in the collection.");
					}
					else 
					{
						_currentFile = ofd.FileName;
						OnFileAdded(ofd.FileName);
					}
				}
				else 
				{
					MessageBox.Show("Unable to open the file - it might not be a TIFF or it might be damaged.");
				}
			}
		}

		private bool AlreadyAddedFile(string fileName) 
		{
			foreach (object o in fileList.Items) 
			{
				FileFramePair pair = (FileFramePair)o;
				if (pair.FileName == fileName)
					return true;
			}
			return false;
		}

		private bool CanOpenThisFileAsTiff(string fname) 
		{
			try 
			{
				using (FileStream stm = new FileStream(fname, FileMode.Open)) 
				{
					// if we can get image info, we can probably do something with the file
					TiffDecoder decoder = new TiffDecoder();
					ImageInfo info = decoder.GetImageInfo(stm);
					return true;
				}
			}
			catch 
			{
				return false;
			}
		}

		private void OnFileAdded(string fileName)
		{
			try 
			{
				ImageInfo info = RegisteredDecoders.GetImageInfo(fileName);
				int offset = thumbnailView1.Items.Count;
				for (int i=0; i < info.FrameCount; i++) 
				{
					FileFramePair pair = new FileFramePair(fileName, i);
					thumbnailView1.Items.Add(fileName, i, pair.ToString() + "\nPage " + i);
					thumbnailView1.Items[offset + i].Tag = pair;
				}
			}
			catch 
			{
			}
			fileList.Items.Add(new FileFramePair(fileName, 0));
		}

		private void saveItem_Click(object sender, System.EventArgs e)
		{
			if (thumbnailView1.Items.Count > 0) 
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "TIFF Image (*.tif)|*.tif";
				if (sfd.ShowDialog() == DialogResult.OK) 
				{
					if (AlreadyAddedFile(sfd.FileName)) 
					{
						MessageBox.Show("Can't save over one of the source files.");
					}
					else 
					{
						SaveTo(sfd.FileName);
					}
				}
			}
		}

		private TiffDocument[] MakeTiffDocuments()
		{
			TiffDocument[] arr = new TiffDocument[fileList.Items.Count];
			for (int i=0; i < arr.Length; i++) 
			{
				FileFramePair pair = (FileFramePair)fileList.Items[i];
				arr[i] = new TiffDocument(pair.FileName);
			}
			return arr;
		}

		private TiffDocument GetTiffDocument(string fileName, TiffDocument[] originals)
		{
			for (int i=0; i < fileList.Items.Count; i++) 
			{
				if (((FileFramePair)fileList.Items[i]).FileName == fileName) 
				{
					return originals[i];
				}
			}
			return null;
		}

		private void SaveTo(string fileName)
		{
			// get a doc for the original
			TiffDocument[] originals = MakeTiffDocuments();
			TiffDocument final = new TiffDocument();
			try 
			{
				// build final from the thumb's Tag object
				foreach (Thumbnail thumb in thumbnailView1.Items) 
				{
					FileFramePair fileFrame = (FileFramePair)thumb.Tag;
					TiffDocument original = GetTiffDocument(fileFrame.FileName, originals);
					if (original == null) 
					{
						MessageBox.Show("Unable to find the original source file " + fileFrame.ToString() + " - this should never happen - skipping file.");
						continue;
					}
					final.Pages.Add(original.Pages[fileFrame.Frame]);
				}
				using (FileStream stm = new FileStream(fileName, FileMode.Create)) 
				{
					final.Save(stm);
				}
			}
			finally 
			{
				// close the original stream
				foreach (TiffDocument doc in originals) 
				{
					doc.Pages[0].Stream.Close();
				}
			}
		}

		private void quitItem_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void thumbnailView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) 
			{
				DeleteItems(thumbnailView1.SelectedItems);
			}
		}

		private void DeleteItems(SelectedThumbnailCollection coll)
		{
			if (coll == null || coll.Count == 0)
				return;

			Thumbnail[] thumbs = new Thumbnail[coll.Count];
			coll.CopyTo(thumbs);
			thumbnailView1.Items.Remove(thumbs);
		}

		private void fileList_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) 
			{
				DeleteFileItems(fileList.SelectedItems);
			}
		}

		private Thumbnail[] GetFileThumbs(FileFramePair pair)
		{
			ArrayList list = new ArrayList();
			foreach (Thumbnail thumb in thumbnailView1.Items)
			{
				if (((FileFramePair)thumb.Tag).FileName == pair.FileName) 
				{
					list.Add(thumb);
				}
			}
			return (Thumbnail[])(list.ToArray(typeof(Thumbnail)));
		}

		private void DeleteFileItems(System.Windows.Forms.ListBox.SelectedObjectCollection coll)
		{
			if (coll == null || coll.Count == 0)
				return;

			for (int i=0; i < coll.Count; i++)
			{
				FileFramePair pair = (FileFramePair)coll[i];
				Thumbnail[] thumbs = GetFileThumbs(pair);
				thumbnailView1.Items.Remove(thumbs);
				fileList.Items.Remove(pair);
			}
		}

		private void menuAbout_Click(object sender, System.EventArgs e)
		{
            AtalaDemos.AboutBox.About aboutBox = new AtalaDemos.AboutBox.About("About Atalasoft TIFF Manipulator Demo", "TIFF Manipulator Demo");
            aboutBox.Description = "Demonstrates page manipulation on TIFF Files including features such as reorder pages, remove pages, combine multiple files, and save the result. This is a Windows Forms application.";
            aboutBox.ShowDialog();
		}

		private void panelEdge_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			ControlPaint.DrawBorder3D(e.Graphics, panelEdge.ClientRectangle, Border3DStyle.Etched, Border3DSide.Bottom);
		}

		private void linkHomePage_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.atalasoft.com");
		}

		private void ShowInstructions()
		{
			if (_instructionForm == null)
			{
				_instructionForm = new Instructions();
				_instructionForm.Disposed += new EventHandler(_instructionForm_Disposed);
			}

			_instructionForm.Show();
		}

		private void _instructionForm_Disposed(object sender, EventArgs e)
		{
			_instructionForm = null;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			ShowInstructions();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Add a slight pause.
			System.Threading.Thread.Sleep(500);

			bool show = true;
			string settings = Application.UserAppDataPath + "\\TiffManipulatorSettings.txt";
			if (System.IO.File.Exists(settings))
			{
				using (System.IO.FileStream reader = new System.IO.FileStream(settings, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read))
				{
					show = (reader.ReadByte() == 1);
				}
			}
			
			if (show) ShowInstructions();
		}
	}
}
