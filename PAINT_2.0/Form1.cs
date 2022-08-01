using System.Drawing.Imaging;
using System.Windows.Input;


namespace PAINT_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //StartPosition = FormStartPosition.CenterScreen;

            /*размер по умолчанию для рисования изоброжения*/
            ////this.Width = 100;
            ////this.Height = 800;
            ///
            ////WindowSize();
            //RoundingPen();
            //RoundingEraser();

            //bm =new Bitmap(pic.Width,pic.Height);
            //g = Graphics.FromImage(bm);
            ////g.Clear(Color.White);
            //pic.Image = bm;

        }

        enum Index
        {
            Clear,
            Line,
            Erase,
            Ellipse,
            Rectangle,
            StraitLine,
            Fill,
            EllipseFill,
            RectangleFill
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White,10);
        Brush b = new SolidBrush(Color.Black);
        
       
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd= new ColorDialog();
        Color newColor;
        private void pic_Click(object sender, EventArgs e)
        {
            
        }

        private void Section(object sender, MouseEventArgs e)
        {

        }

        private void button_ellipse_Click(object sender, EventArgs e)
        {
            index = (int)Index.Ellipse;
        }

        private void button_rectangle_Click(object sender, EventArgs e)
        {
            index = (int)Index.Rectangle;
        }

        private void button_line_Click(object sender, EventArgs e)
        {
            index = (int)Index.StraitLine; 
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if(paint)
            {
                if (index == (int)Index.Ellipse)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == (int)Index.Rectangle)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == (int)Index.StraitLine)
                {
                    g.DrawLine(p, cX, cY, x, y);
                } 
                if(index == (int)Index.EllipseFill)
                {
                    g.FillEllipse(b, cX, cY, sX, sY);
                }
                if (index == (int)Index.RectangleFill)
                {
                    g.FillRectangle(b, cX, cY, sX, sY);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = (int)Index.Clear;
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            picture_color.BackColor=cd.Color;
            p.Color=cd.Color;
            b = new SolidBrush(newColor);
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X*pX), (int)(pt.Y*pY));
        }
        private void picture_color_Click(object sender, EventArgs e)
        {

        }

        private void button_fill_Click(object sender, EventArgs e)
        {
            index = (int)Index.Fill;
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            picture_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            newColor = picture_color.BackColor;
            p.Color = picture_color.BackColor;
            b = new SolidBrush(newColor);
        }

        private void validate(Bitmap bm, Stack<Point>sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx =bm.GetPixel(x, y);
            if(cx==old_color)
            {
                sp.Push(new Point(x,y));
                bm.SetPixel(x,y,new_color);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x,y));
            bm.SetPixel(x,y,new_clr);
            if (old_color == new_clr) return;

            while (pixel.Count>0)
            {
                Point pt = (Point)pixel.Pop();
                if(pt.X>0 && pt.Y>0 && pt.X<bm.Width-1 && pt.Y<bm.Height-1)
                {
                    validate(bm,pixel,pt.X-1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y-1, old_color, new_clr);
                    validate(bm, pixel, pt.X+1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(index==(int)Index.Fill)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, newColor);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var sfd=new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0,0,pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image Saved Sucessfully...");
            }
        }

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_background_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*GIF;*PNG)|*.BMP;*.JPG;*GIF;*PNG|ALL FILES (*.*)|*.*";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    pic.Image=new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Pens_Load(object sender, EventArgs e)
        {

        }

        private void Pens_Resize(object sender, EventArgs e)
        {
            RoundingPen();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            //g.Clear(Color.White);
            pic.Image = bm;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBarPen_ValueChanged(object sender, EventArgs e)
        {
            p.Width = trackBarPen.Value;
        }

        private void trackBarEraser_ValueChanged(object sender, EventArgs e)
        {
            erase.Width = trackBarEraser.Value;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            
            if(paint)
            {
                //рисование карандашем
                if(index==(int)Index.Line)
                {
                    px = e.Location;
                    g.DrawLine(p,px,py);
                    py = px;
                }
                //стерание
                if (index == (int)Index.Erase)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            //начальная и конечная координаты для определения высоты и ширины
            x = e.X;
            y = e.Y;
            sX = e.X-cX;
            sY = e.Y-cY;
        }

        private void button_Ellipse_Fill_Click(object sender, EventArgs e)
        {
            index = (int)Index.EllipseFill;
        }

        private void button_Rectangle_Fill_Click(object sender, EventArgs e)
        {
            index = (int)Index.RectangleFill;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            index = 9;
        }
        
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            //при отпускании мышки рисование завершается
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if(index == (int)Index.Ellipse)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if(index == (int)Index.Rectangle)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if(index == (int)Index.StraitLine)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            if(index == (int)Index.EllipseFill)
            {
                g.FillEllipse(b, cX, cY, sX, sY);
            }
            if (index == (int)Index.RectangleFill)
            {
                g.FillRectangle(b, cX, cY, sX, sY);
            }
            /*if (index == 9)
            {
                g.DrawString(,);
            }*/
        }

        private void color_picker_Click(object sender, EventArgs e)
        {

        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnbuttonBackgroundColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            g.Clear(newColor);
            pic.Image = bm;
        }

        private void button_pencil_Click(object sender, EventArgs e)
        {
            index = (int)Index.Line;
        }

        private void button_eraser_Click(object sender, EventArgs e)
        {
             index=(int)Index.Erase;
        }
        /// <summary>
        /// При щелчке по холсту значение pait меняется на true 
        /// и определяется координата начала рисования 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            //координаты x и y для рисования
            cX = e.X;
            cY = e.Y;
        }

        private void RoundingPen()
        {
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void RoundingEraser()
        {
            erase.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            erase.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        //private void WindowSize()
        //{
        //    Rectangle rectangle = Screen.PrimaryScreen.Bounds;
        //    bm= new Bitmap(rectangle.Width, rectangle.Height);
        //    g = Graphics.FromImage(bm);
        //}
        private void OnFormPaint(object sender, PaintEventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            //this.Width = 100;
            //this.Height = 800;
            //WindowSize();
            RoundingPen();
            RoundingEraser();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            //g.Clear(Color.White);
            pic.Image = bm;
        }


    }
}