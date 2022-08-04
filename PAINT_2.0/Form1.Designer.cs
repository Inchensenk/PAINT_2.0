namespace PAINT_2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarPen = new System.Windows.Forms.TrackBar();
            this.trackBarEraser = new System.Windows.Forms.TrackBar();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.button_ellipse = new System.Windows.Forms.Button();
            this.button_eraser = new System.Windows.Forms.Button();
            this.button_pencil = new System.Windows.Forms.Button();
            this.button_fill = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.picture_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OnbuttonBackgroundColor = new System.Windows.Forms.Button();
            this.OnTextButton = new System.Windows.Forms.Button();
            this.button_Rectangle_Fill = new System.Windows.Forms.Button();
            this.button_background = new System.Windows.Forms.Button();
            this.button_Ellipse_Fill = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarPen);
            this.panel1.Controls.Add(this.trackBarEraser);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.button_ellipse);
            this.panel1.Controls.Add(this.button_eraser);
            this.panel1.Controls.Add(this.button_pencil);
            this.panel1.Controls.Add(this.button_fill);
            this.panel1.Controls.Add(this.button_color);
            this.panel1.Controls.Add(this.picture_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1787, 185);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPanelPaint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(273, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Other thickness";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(373, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Erase thickness";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBarPen
            // 
            this.trackBarPen.BackColor = System.Drawing.Color.AliceBlue;
            this.trackBarPen.Location = new System.Drawing.Point(268, 134);
            this.trackBarPen.Name = "trackBarPen";
            this.trackBarPen.Size = new System.Drawing.Size(95, 45);
            this.trackBarPen.TabIndex = 10;
            this.trackBarPen.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBarPen.ValueChanged += new System.EventHandler(this.OnTrackBarPenValueChanged);
            // 
            // trackBarEraser
            // 
            this.trackBarEraser.BackColor = System.Drawing.Color.AliceBlue;
            this.trackBarEraser.Location = new System.Drawing.Point(369, 134);
            this.trackBarEraser.Name = "trackBarEraser";
            this.trackBarEraser.Size = new System.Drawing.Size(90, 45);
            this.trackBarEraser.TabIndex = 3;
            this.trackBarEraser.ValueChanged += new System.EventHandler(this.OnTrackBarEraserValueChanged);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = ((System.Drawing.Image)(resources.GetObject("color_picker.Image")));
            this.color_picker.Location = new System.Drawing.Point(3, 3);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(248, 128);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 9;
            this.color_picker.TabStop = false;
            this.color_picker.Click += new System.EventHandler(this.color_picker_Click);
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnColorPickerMouseClick);
            // 
            // button_ellipse
            // 
            this.button_ellipse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ellipse.ForeColor = System.Drawing.Color.White;
            this.button_ellipse.Image = ((System.Drawing.Image)(resources.GetObject("button_ellipse.Image")));
            this.button_ellipse.Location = new System.Drawing.Point(657, 15);
            this.button_ellipse.Name = "button_ellipse";
            this.button_ellipse.Size = new System.Drawing.Size(90, 103);
            this.button_ellipse.TabIndex = 5;
            this.button_ellipse.Text = "Ellipse";
            this.button_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_ellipse.UseVisualStyleBackColor = false;
            this.button_ellipse.Click += new System.EventHandler(this.OnButtonEllipseClick);
            // 
            // button_eraser
            // 
            this.button_eraser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eraser.ForeColor = System.Drawing.Color.White;
            this.button_eraser.Image = ((System.Drawing.Image)(resources.GetObject("button_eraser.Image")));
            this.button_eraser.Location = new System.Drawing.Point(561, 15);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(90, 103);
            this.button_eraser.TabIndex = 4;
            this.button_eraser.Text = "Eraser";
            this.button_eraser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_eraser.UseVisualStyleBackColor = false;
            this.button_eraser.Click += new System.EventHandler(this.OnButtonEraserClick);
            // 
            // button_pencil
            // 
            this.button_pencil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pencil.ForeColor = System.Drawing.Color.White;
            this.button_pencil.Image = ((System.Drawing.Image)(resources.GetObject("button_pencil.Image")));
            this.button_pencil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_pencil.Location = new System.Drawing.Point(465, 15);
            this.button_pencil.Name = "button_pencil";
            this.button_pencil.Size = new System.Drawing.Size(90, 103);
            this.button_pencil.TabIndex = 3;
            this.button_pencil.Text = "Pencil";
            this.button_pencil.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_pencil.UseVisualStyleBackColor = false;
            this.button_pencil.Click += new System.EventHandler(this.OnButtonPencilClick);
            // 
            // button_fill
            // 
            this.button_fill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fill.ForeColor = System.Drawing.Color.White;
            this.button_fill.Image = ((System.Drawing.Image)(resources.GetObject("button_fill.Image")));
            this.button_fill.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_fill.Location = new System.Drawing.Point(369, 15);
            this.button_fill.Name = "button_fill";
            this.button_fill.Size = new System.Drawing.Size(90, 103);
            this.button_fill.TabIndex = 2;
            this.button_fill.Text = "Fill";
            this.button_fill.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_fill.UseVisualStyleBackColor = false;
            this.button_fill.Click += new System.EventHandler(this.OnButtonFillClick);
            // 
            // button_color
            // 
            this.button_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_color.ForeColor = System.Drawing.Color.White;
            this.button_color.Image = ((System.Drawing.Image)(resources.GetObject("button_color.Image")));
            this.button_color.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_color.Location = new System.Drawing.Point(273, 15);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(90, 103);
            this.button_color.TabIndex = 1;
            this.button_color.Text = "Color";
            this.button_color.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_color.UseVisualStyleBackColor = false;
            this.button_color.Click += new System.EventHandler(this.OnButtonColorClick);
            // 
            // picture_color
            // 
            this.picture_color.BackColor = System.Drawing.Color.White;
            this.picture_color.Location = new System.Drawing.Point(3, 140);
            this.picture_color.Name = "picture_color";
            this.picture_color.Size = new System.Drawing.Size(49, 45);
            this.picture_color.TabIndex = 0;
            this.picture_color.UseVisualStyleBackColor = false;
            this.picture_color.Click += new System.EventHandler(this.OnPictureColorClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.OnbuttonBackgroundColor);
            this.panel3.Controls.Add(this.OnTextButton);
            this.panel3.Controls.Add(this.button_Rectangle_Fill);
            this.panel3.Controls.Add(this.button_background);
            this.panel3.Controls.Add(this.button_Ellipse_Fill);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Controls.Add(this.button_rectangle);
            this.panel3.Controls.Add(this.button_line);
            this.panel3.Location = new System.Drawing.Point(262, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1486, 120);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3Paint);
            // 
            // OnbuttonBackgroundColor
            // 
            this.OnbuttonBackgroundColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OnbuttonBackgroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnbuttonBackgroundColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.OnbuttonBackgroundColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.OnbuttonBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnbuttonBackgroundColor.ForeColor = System.Drawing.Color.White;
            this.OnbuttonBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("OnbuttonBackgroundColor.Image")));
            this.OnbuttonBackgroundColor.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.OnbuttonBackgroundColor.Location = new System.Drawing.Point(1259, 8);
            this.OnbuttonBackgroundColor.Name = "OnbuttonBackgroundColor";
            this.OnbuttonBackgroundColor.Size = new System.Drawing.Size(90, 103);
            this.OnbuttonBackgroundColor.TabIndex = 15;
            this.OnbuttonBackgroundColor.Text = "Background Color";
            this.OnbuttonBackgroundColor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.OnbuttonBackgroundColor.UseVisualStyleBackColor = false;
            this.OnbuttonBackgroundColor.Click += new System.EventHandler(this.OnbuttonBackgroundColor_Click);
            // 
            // OnTextButton
            // 
            this.OnTextButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OnTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnTextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.OnTextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.OnTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnTextButton.ForeColor = System.Drawing.Color.White;
            this.OnTextButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.OnTextButton.Location = new System.Drawing.Point(779, 8);
            this.OnTextButton.Name = "OnTextButton";
            this.OnTextButton.Size = new System.Drawing.Size(90, 103);
            this.OnTextButton.TabIndex = 14;
            this.OnTextButton.Text = "Text";
            this.OnTextButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.OnTextButton.UseVisualStyleBackColor = false;
            this.OnTextButton.Click += new System.EventHandler(this.OnButtonTextClick);
            // 
            // button_Rectangle_Fill
            // 
            this.button_Rectangle_Fill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Rectangle_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Rectangle_Fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_Rectangle_Fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Rectangle_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rectangle_Fill.ForeColor = System.Drawing.Color.White;
            this.button_Rectangle_Fill.Location = new System.Drawing.Point(683, 8);
            this.button_Rectangle_Fill.Name = "button_Rectangle_Fill";
            this.button_Rectangle_Fill.Size = new System.Drawing.Size(90, 103);
            this.button_Rectangle_Fill.TabIndex = 13;
            this.button_Rectangle_Fill.Text = "RectangleFill";
            this.button_Rectangle_Fill.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_Rectangle_Fill.UseVisualStyleBackColor = false;
            this.button_Rectangle_Fill.Click += new System.EventHandler(this.OnButtonRectangleFillClick);
            // 
            // button_background
            // 
            this.button_background.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_background.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_background.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_background.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_background.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_background.ForeColor = System.Drawing.Color.White;
            this.button_background.Image = ((System.Drawing.Image)(resources.GetObject("button_background.Image")));
            this.button_background.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_background.Location = new System.Drawing.Point(1163, 8);
            this.button_background.Name = "button_background";
            this.button_background.Size = new System.Drawing.Size(90, 103);
            this.button_background.TabIndex = 11;
            this.button_background.Text = "Background";
            this.button_background.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_background.UseVisualStyleBackColor = false;
            this.button_background.Click += new System.EventHandler(this.OnButtonBackgroundClick);
            // 
            // button_Ellipse_Fill
            // 
            this.button_Ellipse_Fill.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Ellipse_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Ellipse_Fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_Ellipse_Fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_Ellipse_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ellipse_Fill.ForeColor = System.Drawing.Color.White;
            this.button_Ellipse_Fill.Location = new System.Drawing.Point(491, 8);
            this.button_Ellipse_Fill.Name = "button_Ellipse_Fill";
            this.button_Ellipse_Fill.Size = new System.Drawing.Size(90, 103);
            this.button_Ellipse_Fill.TabIndex = 12;
            this.button_Ellipse_Fill.Text = "EllipseFill";
            this.button_Ellipse_Fill.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_Ellipse_Fill.UseVisualStyleBackColor = false;
            this.button_Ellipse_Fill.Click += new System.EventHandler(this.OnButtonEllipseFillClick);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Image = ((System.Drawing.Image)(resources.GetObject("button_clear.Image")));
            this.button_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_clear.Location = new System.Drawing.Point(971, 8);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(90, 103);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Clear";
            this.button_clear.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.OnButtonClearClick);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_save.Location = new System.Drawing.Point(1067, 8);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(90, 103);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Save";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.OnButtonSaveClick);
            // 
            // button_rectangle
            // 
            this.button_rectangle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rectangle.ForeColor = System.Drawing.Color.White;
            this.button_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("button_rectangle.Image")));
            this.button_rectangle.Location = new System.Drawing.Point(587, 8);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(90, 103);
            this.button_rectangle.TabIndex = 6;
            this.button_rectangle.Text = "Rectangle";
            this.button_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_rectangle.UseVisualStyleBackColor = false;
            this.button_rectangle.Click += new System.EventHandler(this.OnButtonRectangleClick);
            // 
            // button_line
            // 
            this.button_line.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_line.ForeColor = System.Drawing.Color.White;
            this.button_line.Image = ((System.Drawing.Image)(resources.GetObject("button_line.Image")));
            this.button_line.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_line.Location = new System.Drawing.Point(875, 8);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(90, 103);
            this.button_line.TabIndex = 7;
            this.button_line.Text = "Line";
            this.button_line.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_line.UseVisualStyleBackColor = false;
            this.button_line.Click += new System.EventHandler(this.OnButtonLineClick);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 185);
            this.pic.MinimumSize = new System.Drawing.Size(1271, 627);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1787, 627);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.OnPicClick);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.PicPaint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnPicMouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPicMouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPicMouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPicMouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 607);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(682, 349);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paint 2.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pens_Load);
            this.Resize += new System.EventHandler(this.PensResize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

     
        #endregion

        private Panel panel1;
        private PictureBox pic;
        private Button button_color;
        private Button picture_color;
        private Button button_fill;
        private Button button_line;
        private Button button_rectangle;
        private Button button_ellipse;
        private Button button_eraser;
        private Button button_pencil;
        private Panel panel3;
        private PictureBox color_picker;
        private Button button_save;
        private Button button_clear;
        private TrackBar trackBarPen;
        private Button button_background;
        private TrackBar trackBarEraser;
        private Button button_Rectangle_Fill;
        private Button button_Ellipse_Fill;
        private Button OnTextButton;
        private Button OnbuttonBackgroundColor;
        private Label label2;
        private Label label1;
    }
}