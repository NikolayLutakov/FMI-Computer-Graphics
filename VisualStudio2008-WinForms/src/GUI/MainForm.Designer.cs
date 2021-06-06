namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseStripButton = new System.Windows.Forms.ToolStripButton();
            this.drawTriangleStripButton = new System.Windows.Forms.ToolStripButton();
            this.borderColorStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillColor = new System.Windows.Forms.ToolStripButton();
            this.rotateItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.increaseBorderSize = new System.Windows.Forms.ToolStripButton();
            this.decreaseBorderSize = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.increaseShapeSizeButton = new System.Windows.Forms.ToolStripButton();
            this.decreaseShapeSize = new System.Windows.Forms.ToolStripButton();
            this.deleteSelectedButton = new System.Windows.Forms.ToolStripButton();
            this.groupShapesButton = new System.Windows.Forms.ToolStripButton();
            this.borderColorDialog = new System.Windows.Forms.ColorDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.addCircle = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1040, 36);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.LoadButton});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(153, 34);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(153, 34);
            this.LoadButton.Text = "Load";
            this.LoadButton.Click += new System.EventHandler(this.Load_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 629);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusBar.Size = new System.Drawing.Size(1040, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // speedMenu
            // 
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pickUpSpeedButton,
            this.drawRectangleSpeedButton,
            this.drawEllipseStripButton,
            this.drawTriangleStripButton,
            this.borderColorStripButton,
            this.fillColor,
            this.rotateItem,
            this.toolStripLabel1,
            this.increaseBorderSize,
            this.decreaseBorderSize,
            this.toolStripLabel2,
            this.increaseShapeSizeButton,
            this.decreaseShapeSize,
            this.deleteSelectedButton,
            this.groupShapesButton,
            this.addCircle});
            this.speedMenu.Location = new System.Drawing.Point(0, 36);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.speedMenu.Size = new System.Drawing.Size(1040, 38);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(34, 33);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(34, 33);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // drawEllipseStripButton
            // 
            this.drawEllipseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseStripButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseStripButton.Image")));
            this.drawEllipseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseStripButton.Name = "drawEllipseStripButton";
            this.drawEllipseStripButton.Size = new System.Drawing.Size(34, 33);
            this.drawEllipseStripButton.Text = "Draw Ellipse";
            this.drawEllipseStripButton.Click += new System.EventHandler(this.DrawEllipseButton_Click);
            // 
            // drawTriangleStripButton
            // 
            this.drawTriangleStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawTriangleStripButton.Image = ((System.Drawing.Image)(resources.GetObject("drawTriangleStripButton.Image")));
            this.drawTriangleStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawTriangleStripButton.Name = "drawTriangleStripButton";
            this.drawTriangleStripButton.Size = new System.Drawing.Size(34, 33);
            this.drawTriangleStripButton.Text = "Draw Triangle";
            this.drawTriangleStripButton.Click += new System.EventHandler(this.DrawTriangleButton_Click);
            // 
            // borderColorStripButton
            // 
            this.borderColorStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.borderColorStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.borderColorStripButton.Name = "borderColorStripButton";
            this.borderColorStripButton.Size = new System.Drawing.Size(117, 33);
            this.borderColorStripButton.Text = "Border Color";
            this.borderColorStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.borderColorStripButton.Click += new System.EventHandler(this.borderColorStripButton_Click);
            // 
            // fillColor
            // 
            this.fillColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillColor.Image = ((System.Drawing.Image)(resources.GetObject("fillColor.Image")));
            this.fillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillColor.Name = "fillColor";
            this.fillColor.Size = new System.Drawing.Size(85, 33);
            this.fillColor.Text = "Fill Color";
            this.fillColor.Click += new System.EventHandler(this.fillColor_Click);
            // 
            // rotateItem
            // 
            this.rotateItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rotateItem.Image = ((System.Drawing.Image)(resources.GetObject("rotateItem.Image")));
            this.rotateItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateItem.Name = "rotateItem";
            this.rotateItem.Size = new System.Drawing.Size(92, 33);
            this.rotateItem.Text = "Rotete 90";
            this.rotateItem.Click += new System.EventHandler(this.rotateItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 33);
            this.toolStripLabel1.Text = "Border Size";
            // 
            // increaseBorderSize
            // 
            this.increaseBorderSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseBorderSize.Image = ((System.Drawing.Image)(resources.GetObject("increaseBorderSize.Image")));
            this.increaseBorderSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseBorderSize.Name = "increaseBorderSize";
            this.increaseBorderSize.Size = new System.Drawing.Size(34, 33);
            this.increaseBorderSize.Text = "increaseBorderSizeButton";
            this.increaseBorderSize.Click += new System.EventHandler(this.incfreaseBorderSize);
            // 
            // decreaseBorderSize
            // 
            this.decreaseBorderSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseBorderSize.Image = ((System.Drawing.Image)(resources.GetObject("decreaseBorderSize.Image")));
            this.decreaseBorderSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseBorderSize.Name = "decreaseBorderSize";
            this.decreaseBorderSize.Size = new System.Drawing.Size(34, 33);
            this.decreaseBorderSize.Text = "decraseBorderSizeButton";
            this.decreaseBorderSize.Click += new System.EventHandler(this.decreaseBorderSize_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(97, 33);
            this.toolStripLabel2.Text = "Shape Size";
            // 
            // increaseShapeSizeButton
            // 
            this.increaseShapeSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseShapeSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("increaseShapeSizeButton.Image")));
            this.increaseShapeSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseShapeSizeButton.Name = "increaseShapeSizeButton";
            this.increaseShapeSizeButton.Size = new System.Drawing.Size(34, 33);
            this.increaseShapeSizeButton.Text = "increaseShapeSize";
            this.increaseShapeSizeButton.Click += new System.EventHandler(this.increaseShapeSizeButton_Click);
            // 
            // decreaseShapeSize
            // 
            this.decreaseShapeSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseShapeSize.Image = ((System.Drawing.Image)(resources.GetObject("decreaseShapeSize.Image")));
            this.decreaseShapeSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseShapeSize.Name = "decreaseShapeSize";
            this.decreaseShapeSize.Size = new System.Drawing.Size(34, 33);
            this.decreaseShapeSize.Text = "decreaseShapeButton";
            this.decreaseShapeSize.Click += new System.EventHandler(this.decreaseShapeSize_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteSelectedButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteSelectedButton.Image")));
            this.deleteSelectedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(34, 33);
            this.deleteSelectedButton.Text = "deleteSelected";
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // groupShapesButton
            // 
            this.groupShapesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.groupShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("groupShapesButton.Image")));
            this.groupShapesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groupShapesButton.Name = "groupShapesButton";
            this.groupShapesButton.Size = new System.Drawing.Size(123, 33);
            this.groupShapesButton.Text = "GroupShapes";
            this.groupShapesButton.Click += new System.EventHandler(this.groupShapesButton_Click);
            // 
            // viewPort
            // 
            this.viewPort.AllowDrop = true;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 74);
            this.viewPort.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1040, 555);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // addCircle
            // 
            this.addCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addCircle.Image = ((System.Drawing.Image)(resources.GetObject("addCircle.Image")));
            this.addCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCircle.Name = "addCircle";
            this.addCircle.Size = new System.Drawing.Size(34, 33);
            this.addCircle.Text = "addCircle";
            this.addCircle.Click += new System.EventHandler(this.addCircle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 651);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton drawEllipseStripButton;
        private System.Windows.Forms.ToolStripButton drawTriangleStripButton;
        private System.Windows.Forms.ToolStripButton borderColorStripButton;
        private System.Windows.Forms.ColorDialog borderColorDialog;
        private System.Windows.Forms.ToolStripButton fillColor;
        private System.Windows.Forms.ToolStripButton rotateItem;
        private System.Windows.Forms.ComboBox BorderSize;
        private System.Windows.Forms.Label BorderSizeLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton increaseBorderSize;
        private System.Windows.Forms.ToolStripButton decreaseBorderSize;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton increaseShapeSizeButton;
        private System.Windows.Forms.ToolStripButton decreaseShapeSize;
        private System.Windows.Forms.ToolStripButton deleteSelectedButton;
        private System.Windows.Forms.ToolStripButton groupShapesButton;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.ToolStripMenuItem LoadButton;
        private System.Windows.Forms.ToolStripButton addCircle;
    }
}
