namespace CourseProjectGemoetry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.figureSelector = new System.Windows.Forms.ComboBox();
            this.textBoxStrokeSize = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fillColorButton = new System.Windows.Forms.Button();
            this.outlineColorButton = new System.Windows.Forms.Button();
            this.clearBoardButton = new System.Windows.Forms.Button();
            this.moveFigure = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.changeFillColor = new System.Windows.Forms.Button();
            this.changeOutlineColor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoCtrlZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.eraserButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureSelector
            // 
            this.figureSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figureSelector.FormattingEnabled = true;
            this.figureSelector.Location = new System.Drawing.Point(3, 14);
            this.figureSelector.Name = "figureSelector";
            this.figureSelector.Size = new System.Drawing.Size(129, 24);
            this.figureSelector.TabIndex = 0;
            this.toolTip1.SetToolTip(this.figureSelector, "Select Figure");
            this.figureSelector.SelectedIndexChanged += new System.EventHandler(this.figureSelector_SelectedIndexChanged);
            // 
            // textBoxStrokeSize
            // 
            this.textBoxStrokeSize.Location = new System.Drawing.Point(418, 23);
            this.textBoxStrokeSize.Name = "textBoxStrokeSize";
            this.textBoxStrokeSize.Size = new System.Drawing.Size(58, 22);
            this.textBoxStrokeSize.TabIndex = 1;
            // 
            // fillColorButton
            // 
            this.fillColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillColorButton.Location = new System.Drawing.Point(712, 3);
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(129, 41);
            this.fillColorButton.TabIndex = 2;
            this.fillColorButton.Text = "Fill Color";
            this.toolTip1.SetToolTip(this.fillColorButton, "Select Fill Color");
            this.fillColorButton.UseVisualStyleBackColor = true;
            this.fillColorButton.Click += new System.EventHandler(this.fillColorButton_Click);
            // 
            // outlineColorButton
            // 
            this.outlineColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outlineColorButton.Location = new System.Drawing.Point(847, 3);
            this.outlineColorButton.Name = "outlineColorButton";
            this.outlineColorButton.Size = new System.Drawing.Size(129, 41);
            this.outlineColorButton.TabIndex = 3;
            this.outlineColorButton.Text = "Outline Color";
            this.toolTip1.SetToolTip(this.outlineColorButton, "Select Outline Color");
            this.outlineColorButton.UseVisualStyleBackColor = true;
            this.outlineColorButton.Click += new System.EventHandler(this.outlineColorButton_Click);
            // 
            // clearBoardButton
            // 
            this.clearBoardButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBoardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearBoardButton.BackgroundImage")));
            this.clearBoardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBoardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBoardButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.clearBoardButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.clearBoardButton.Location = new System.Drawing.Point(369, 3);
            this.clearBoardButton.Name = "clearBoardButton";
            this.clearBoardButton.Size = new System.Drawing.Size(40, 40);
            this.clearBoardButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.clearBoardButton, "Clear Board");
            this.clearBoardButton.UseVisualStyleBackColor = false;
            this.clearBoardButton.Click += new System.EventHandler(this.clearBoardButton_Click);
            // 
            // moveFigure
            // 
            this.moveFigure.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.moveFigure.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moveFigure.BackgroundImage")));
            this.moveFigure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveFigure.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.moveFigure.FlatAppearance.BorderSize = 0;
            this.moveFigure.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.moveFigure.Location = new System.Drawing.Point(138, 3);
            this.moveFigure.Name = "moveFigure";
            this.moveFigure.Size = new System.Drawing.Size(40, 40);
            this.moveFigure.TabIndex = 5;
            this.toolTip1.SetToolTip(this.moveFigure, "Move");
            this.moveFigure.UseVisualStyleBackColor = false;
            this.moveFigure.Click += new System.EventHandler(this.moveFigure_Click);
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.drawButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drawButton.BackgroundImage")));
            this.drawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawButton.Enabled = false;
            this.drawButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.drawButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.drawButton.Location = new System.Drawing.Point(185, 3);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(40, 40);
            this.drawButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.drawButton, "Draw");
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // changeFillColor
            // 
            this.changeFillColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeFillColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeFillColor.BackgroundImage")));
            this.changeFillColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeFillColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeFillColor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.changeFillColor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.changeFillColor.Location = new System.Drawing.Point(231, 3);
            this.changeFillColor.Name = "changeFillColor";
            this.changeFillColor.Size = new System.Drawing.Size(40, 40);
            this.changeFillColor.TabIndex = 7;
            this.toolTip1.SetToolTip(this.changeFillColor, "Bucket/Fill Figure");
            this.changeFillColor.UseVisualStyleBackColor = false;
            this.changeFillColor.Click += new System.EventHandler(this.changeFillColor_Click);
            // 
            // changeOutlineColor
            // 
            this.changeOutlineColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.changeOutlineColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeOutlineColor.BackgroundImage")));
            this.changeOutlineColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeOutlineColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeOutlineColor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.changeOutlineColor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.changeOutlineColor.Location = new System.Drawing.Point(277, 3);
            this.changeOutlineColor.Name = "changeOutlineColor";
            this.changeOutlineColor.Size = new System.Drawing.Size(40, 40);
            this.changeOutlineColor.TabIndex = 8;
            this.toolTip1.SetToolTip(this.changeOutlineColor, "Pen Color/Outline Color");
            this.changeOutlineColor.UseVisualStyleBackColor = false;
            this.changeOutlineColor.Click += new System.EventHandler(this.changeOutlineColor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.undoCtrlZToolStripMenuItem,
            this.redoCtrlXToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.openProjectToolStripMenuItem.Text = "Open project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // undoCtrlZToolStripMenuItem
            // 
            this.undoCtrlZToolStripMenuItem.Name = "undoCtrlZToolStripMenuItem";
            this.undoCtrlZToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.undoCtrlZToolStripMenuItem.Text = "Undo (Ctrl+Z)";
            this.undoCtrlZToolStripMenuItem.Click += new System.EventHandler(this.undoCtrlZToolStripMenuItem_Click);
            // 
            // redoCtrlXToolStripMenuItem
            // 
            this.redoCtrlXToolStripMenuItem.Name = "redoCtrlXToolStripMenuItem";
            this.redoCtrlXToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.redoCtrlXToolStripMenuItem.Text = "Redo (Ctrl + X)";
            this.redoCtrlXToolStripMenuItem.Click += new System.EventHandler(this.redoCtrlXToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.eraserButton);
            this.panel1.Controls.Add(this.changeOutlineColor);
            this.panel1.Controls.Add(this.moveFigure);
            this.panel1.Controls.Add(this.textBoxStrokeSize);
            this.panel1.Controls.Add(this.changeFillColor);
            this.panel1.Controls.Add(this.drawButton);
            this.panel1.Controls.Add(this.figureSelector);
            this.panel1.Controls.Add(this.fillColorButton);
            this.panel1.Controls.Add(this.outlineColorButton);
            this.panel1.Controls.Add(this.clearBoardButton);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 49);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stroke Size";
            // 
            // eraserButton
            // 
            this.eraserButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eraserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraserButton.BackgroundImage")));
            this.eraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraserButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.eraserButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.eraserButton.Location = new System.Drawing.Point(323, 3);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(40, 40);
            this.eraserButton.TabIndex = 9;
            this.eraserButton.UseVisualStyleBackColor = false;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(979, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox figureSelector;
        private System.Windows.Forms.TextBox textBoxStrokeSize;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button fillColorButton;
        private System.Windows.Forms.Button outlineColorButton;
        private System.Windows.Forms.Button clearBoardButton;
        private System.Windows.Forms.Button moveFigure;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Button changeFillColor;
        private System.Windows.Forms.Button changeOutlineColor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem undoCtrlZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
    }
}

