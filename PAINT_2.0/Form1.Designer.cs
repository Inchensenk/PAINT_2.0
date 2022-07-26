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
            this.button_save = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.button_line = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_ellipse = new System.Windows.Forms.Button();
            this.button_eraser = new System.Windows.Forms.Button();
            this.button_pencil = new System.Windows.Forms.Button();
            this.button_fill = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.picture_color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.button_line);
            this.panel1.Controls.Add(this.button_rectangle);
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
            this.panel1.Size = new System.Drawing.Size(1233, 158);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.button_save.Location = new System.Drawing.Point(1109, 28);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(90, 103);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "Save";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = ((System.Drawing.Image)(resources.GetObject("color_picker.Image")));
            this.color_picker.Location = new System.Drawing.Point(12, 12);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(248, 128);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 9;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
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
            this.button_line.Location = new System.Drawing.Point(917, 28);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(90, 103);
            this.button_line.TabIndex = 7;
            this.button_line.Text = "Line";
            this.button_line.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_line.UseVisualStyleBackColor = false;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
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
            this.button_rectangle.Location = new System.Drawing.Point(821, 28);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(90, 103);
            this.button_rectangle.TabIndex = 6;
            this.button_rectangle.Text = "Rectangle";
            this.button_rectangle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_rectangle.UseVisualStyleBackColor = false;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
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
            this.button_ellipse.Location = new System.Drawing.Point(725, 28);
            this.button_ellipse.Name = "button_ellipse";
            this.button_ellipse.Size = new System.Drawing.Size(90, 103);
            this.button_ellipse.TabIndex = 5;
            this.button_ellipse.Text = "Ellipse";
            this.button_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_ellipse.UseVisualStyleBackColor = false;
            this.button_ellipse.Click += new System.EventHandler(this.button_ellipse_Click);
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
            this.button_eraser.Location = new System.Drawing.Point(629, 28);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(90, 103);
            this.button_eraser.TabIndex = 4;
            this.button_eraser.Text = "Eraser";
            this.button_eraser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_eraser.UseVisualStyleBackColor = false;
            this.button_eraser.Click += new System.EventHandler(this.button_eraser_Click);
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
            this.button_pencil.Location = new System.Drawing.Point(533, 28);
            this.button_pencil.Name = "button_pencil";
            this.button_pencil.Size = new System.Drawing.Size(90, 103);
            this.button_pencil.TabIndex = 3;
            this.button_pencil.Text = "Pencil";
            this.button_pencil.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_pencil.UseVisualStyleBackColor = false;
            this.button_pencil.Click += new System.EventHandler(this.button_pencil_Click);
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
            this.button_fill.Location = new System.Drawing.Point(437, 28);
            this.button_fill.Name = "button_fill";
            this.button_fill.Size = new System.Drawing.Size(90, 103);
            this.button_fill.TabIndex = 2;
            this.button_fill.Text = "Fill";
            this.button_fill.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_fill.UseVisualStyleBackColor = false;
            this.button_fill.Click += new System.EventHandler(this.button_fill_Click);
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
            this.button_color.Location = new System.Drawing.Point(341, 28);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(90, 103);
            this.button_color.TabIndex = 1;
            this.button_color.Text = "Color";
            this.button_color.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_color.UseVisualStyleBackColor = false;
            this.button_color.Click += new System.EventHandler(this.button_color_Click);
            // 
            // picture_color
            // 
            this.picture_color.BackColor = System.Drawing.Color.White;
            this.picture_color.Location = new System.Drawing.Point(266, 60);
            this.picture_color.Name = "picture_color";
            this.picture_color.Size = new System.Drawing.Size(49, 45);
            this.picture_color.TabIndex = 0;
            this.picture_color.UseVisualStyleBackColor = false;
            this.picture_color.Click += new System.EventHandler(this.picture_color_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Location = new System.Drawing.Point(330, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 120);
            this.panel3.TabIndex = 8;
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
            this.button_clear.Location = new System.Drawing.Point(683, 8);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(90, 103);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Clear";
            this.button_clear.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 40);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1233, 620);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
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
    }
}