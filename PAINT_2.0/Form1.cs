using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Input;


namespace PAINT_2._0
{
    
    public partial class Form1 : Form
    {

        private Action<Graphics> _onPaint;
        public Form1()
        {
            InitializeComponent();
           
        }

        /// <summary>
        /// Инкапсулирует точечный рисунок GDI+, состоящий из данных пикселей графического изображения и атрибутов рисунка. 
        /// Объект Bitmap используется для работы с изображениями, определяемыми данными пикселей.
        /// </summary>
        Bitmap bm;

        /// <summary>
        /// Инкапсулирует поверхность рисования GDI+. Этот класс не наследуется.
        /// </summary>
        Graphics g;

        /// <summary>
        /// Флаг обозначающий действие рисования
        /// </summary>
        bool paint = false;

        /// <summary>
        /// Представляет упорядоченную пару целых чисел — координат Х и Y, определяющую точку на двумерной плоскости.
        /// </summary>
        Point px, py;

        /// <summary>
        /// Определяет объект, используемый для рисования прямых линий и кривых. Этот класс не наследуется.
        /// </summary>
        Pen p = new Pen(Color.Black, 1);


        /// <summary>
        /// Стерка(обьект для рисования белым цветом)
        /// </summary>
        Pen erase = new Pen(Color.White,10);

        /// <summary>
        /// Определяет объекты, которые используются для заливки внутри графических фигур, 
        /// таких как прямоугольники, эллипсы, круги, многоугольники и дорожки.
        /// </summary>
        Brush b = new SolidBrush(Color.Black);
        
        /// <summary>
        /// Переменная, которая хранит выбранное значение которое будет интерпритироваться с обьектом рисования
        /// </summary>
        int index;
        int x, y, sX, sY, cX, cY;

        /// <summary>
        /// Представляет общее диалоговое окно, в котором отображаются доступные цвета и элементы управления, 
        /// позволяющие пользователю определять собственные цвета.
        /// </summary>
        ColorDialog cd = new ColorDialog();

        Color newColor;



        private void OnButtonEllipseClick(object sender, EventArgs e)
        {
            index = (int)Index.Ellipse;
        }

        private void OnButtonRectangleClick(object sender, EventArgs e)
        {
            index = (int)Index.Rectangle;
        }

        private void OnButtonLineClick(object sender, EventArgs e)
        {
            index = (int)Index.StraitLine; 
        }

        private void PicPaint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            
            //g = e.Graphics;
            

            if (paint)
            {
                if (index == (int)Index.Ellipse)
                {
                    //g.DrawEllipse(p, cX, cY, sX, sY);
                    _onPaint += (graphics) => { graphics.DrawEllipse(p, cX, cY, sX, sY); };
                    pic.Invalidate();
                    return;
                }
                

                if (index == (int)Index.Rectangle)
                {
                    //g.DrawRectangle(p, cX, cY, sX, sY);
                    _onPaint += (graphics) => { graphics.DrawRectangle(p, cX, cY, sX, sY); };
                    pic.Invalidate();
                    return;
                }

                if (index == (int)Index.StraitLine)
                {
                    //g.DrawLine(p, cX, cY, x, y);
                    _onPaint += (graphics) => { graphics.DrawLine(p, cX, cY, x, y); };
                    pic.Invalidate();
                    return;
                } 

                if(index == (int)Index.EllipseFill)
                {
                    //g.FillEllipse(b, cX, cY, sX, sY);
                    _onPaint += (graphics) => { graphics.FillEllipse(b, cX, cY, sX, sY); };
                    pic.Invalidate();
                    return;
                }

                if (index == (int)Index.RectangleFill)
                {
                    //g.FillRectangle(b, cX, cY, sX, sY);
                    _onPaint += (graphics) => { graphics.FillRectangle(b, cX, cY, sX, sY); };
                    pic.Invalidate();
                    return;
                }

                //if (index==(int)Index.Text)
                //{
                //    if(OnTextBox.Text=="")
                //    {
                //        MessageBox.Show("");
                //    }
                //    string text = OnTextBox.Text;
                //    Font font = new Font("Verdana", 30, FontStyle.Italic);
                //    g.DrawString(text,font, new SolidBrush(newColor), cX, cY);
                //}
            }

            _onPaint?.Invoke(e.Graphics);
        }

        private void OnButtonClearClick(object sender, EventArgs e)
        {

            //g.Clear(Color.White);

            _onPaint += (graphics) => { graphics.Clear(Color.White); };

            pic.Image = bm;
            index = (int)Index.Clear;
        }

        private void OnButtonColorClick(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            picture_color.BackColor=cd.Color;
            p.Color=cd.Color;
            b = new SolidBrush(newColor);
        }
        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X*pX), (int)(pt.Y*pY));
        }


        private void OnButtonFillClick(object sender, EventArgs e)
        {
            index = (int)Index.Fill;
        }

        private void OnColorPickerMouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(color_picker, e.Location);
            picture_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            newColor = picture_color.BackColor;
            p.Color = picture_color.BackColor;
            b = new SolidBrush(newColor);
        }

        private void Validate(Bitmap bm, Stack<Point>sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
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
                    Validate(bm, pixel,pt.X-1, pt.Y, old_color, new_clr);
                    Validate(bm, pixel, pt.X, pt.Y-1, old_color, new_clr);
                    Validate(bm, pixel, pt.X+1, pt.Y, old_color, new_clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void OnPicMouseClick(object sender, MouseEventArgs e)
        {
            if(index==(int)Index.Fill)
            {
                Point point = SetPoint(pic, e.Location);
                Fill(bm, point.X, point.Y, newColor);
            }
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
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

        private void OnButtonBackgroundClick(object sender, EventArgs e)
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

        private void PensResize(object sender, EventArgs e)
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

        private void OnTrackBarPenValueChanged(object sender, EventArgs e)
        {
            p.Width = trackBarPen.Value;
        }

        private void OnTrackBarEraserValueChanged(object sender, EventArgs e)
        {
            erase.Width = trackBarEraser.Value;
        }

        private void OnPicMouseMove(object sender, MouseEventArgs e)
        {
            
            if(paint)
            {
                //рисование карандашем
                if(index==(int)Index.Line)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    //_onPaint += (graphics) => { graphics.DrawLine(p, px, py); };
                    py = px;
                    //pic.Invalidate();
                    
                }
                //стерание
                if (index == (int)Index.Erase)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    //_onPaint += (graphics) => { graphics.DrawLine(p, px, py); };
                    py = px;
                    //pic.Invalidate();
                }
            }
            pic.Refresh();

            //начальная и конечная координаты для определения высоты и ширины
            x = e.X;
            y = e.Y;
            sX = e.X-cX;
            sY = e.Y-cY;

           
        }


        private void OnButtonEllipseFillClick(object sender, EventArgs e)
        {
            index = (int)Index.EllipseFill;
        }


        private void OnButtonRectangleFillClick(object sender, EventArgs e)
        {
            index = (int)Index.RectangleFill;
        }

      

        private void OnButtonTextClick(object sender, EventArgs e)
        {
            index = (int)Index.Text;
        }
        
        private void OnPicMouseUp(object sender, MouseEventArgs e)
        {
            //при отпускании мышки рисование завершается
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if(index == (int)Index.Ellipse)
            {
                //g.DrawEllipse(p, cX, cY, sX, sY);
                _onPaint += (graphics) => {graphics.DrawEllipse(p, cX, cY, sX, sY); };
                pic.Invalidate();
                return;
            }
            if(index == (int)Index.Rectangle)
            {
                //g.DrawRectangle(p, cX, cY, sX, sY);
                _onPaint+= (graphics) => { graphics.DrawRectangle(p, cX, cY, sX, sY); };
                pic.Invalidate();
                return;
            }
            if(index == (int)Index.StraitLine)
            {
                //g.DrawLine(p, cX, cY, x, y);
                _onPaint += (graphics) => { graphics.DrawLine(p, cX, cY, x, y); };
                pic.Invalidate();
            }
            if(index == (int)Index.EllipseFill)
            {
                //g.FillEllipse(b, cX, cY, sX, sY);
                _onPaint += (graphics) => { graphics.FillEllipse(b, cX, cY, sX, sY); };
                pic.Invalidate();
            }
            if (index == (int)Index.RectangleFill)
            {
                //g.FillRectangle(b, cX, cY, sX, sY);
                _onPaint += (graphics) => { graphics.FillRectangle(b, cX, cY, sX, sY); };
                pic.Invalidate(true);
            }
            if (index == (int)Index.Text)
            {
                if (OnTextBox.Text == "")
                {
                    MessageBox.Show("ОШИБКА! НЕТ ДАННЫХ ДЛЯ РИСОВАНИЯ!\nВВЕДИТЕ ТЕКСТ В ТЕКСТОВОЕ ПОЛЕ");
                }
                string text = OnTextBox.Text;
                Font font = new Font("Verdana", 30, FontStyle.Italic);
                //g.DrawString(text, font, new SolidBrush(newColor), cX, cY);
                _onPaint += (graphics) => { graphics.DrawString(text, font, new SolidBrush(newColor), cX, cY); };
                pic.Invalidate();
            }
            
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void OnbuttonBackgroundColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            g.Clear(newColor);
            pic.Image = bm;
        }


        private void OnButtonPencilClick(object sender, EventArgs e)
        {
            index = (int)Index.Line;
        }

        private void OnButtonEraserClick(object sender, EventArgs e)
        {
             index=(int)Index.Erase;
        }

        private void OnPicMouseDown(object sender, MouseEventArgs e)
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


        //private void OnFormPaint(object sender, PaintEventArgs e)
        //{
        //    StartPosition = FormStartPosition.CenterScreen;
        //    RoundingPen();
        //    RoundingEraser();
        //    bm = new Bitmap(pic.Width, pic.Height);
        //    g = Graphics.FromImage(bm);
        //    pic.Image = bm;

        //}


    }
}