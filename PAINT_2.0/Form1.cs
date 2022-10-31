using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Reflection;
using System.Windows.Input;


namespace PAINT_2._0
{
    
    public partial class Form1 : Form
    {

        private Action<Graphics> _onPaint;
        private Action<Graphics> _onPaintPreview;
        private Action _currentAction;
        //private delegate void PaintDelegate();

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
        //Graphics g;

        /// <summary>
        /// Флаг обозначающий действие рисования
        /// </summary>
        bool isPaint = false;

        /// <summary>
        /// Представляет упорядоченную пару целых чисел — координат Х и Y, определяющую точку на двумерной плоскости.
        /// </summary>
        Point px, startCursorPosition;

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


        //*****************************************Кнопки
        private void OnButtonEllipseClick(object sender, EventArgs e)
        {
            _currentAction = DrawEllipseOrPreview;
        }

        private void OnButtonRectangleClick(object sender, EventArgs e)
        {
            _currentAction = DrawRectangleOrPreview;
        }

        private void OnButtonLineClick(object sender, EventArgs e)
        {
            _currentAction = DrawStraightLineOrPreview;
        }

        /// <summary>
        /// Полная очистка окна рисования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonClearClick(object sender, EventArgs e)
        {
            _onPaint += (graphics) => { graphics.Clear(Color.White); };
            MainPictureBox.Image = bm;    
        }

        private void OnButtonColorClick(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            picture_color.BackColor = cd.Color;
            p.Color = cd.Color;
            b = new SolidBrush(newColor);
        }

        private void OnButtonFillClick(object sender, EventArgs e)
        {
            index = (int)Index.Fill;
        }

        private void OnPicMouseClick(object sender, MouseEventArgs e)
        {
            if (index == (int)Index.Fill)
            {
                Point point = SetPoint(MainPictureBox, e.Location);
                Fill(bm, point.X, point.Y, newColor);
            }
        }

        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, MainPictureBox.Width, MainPictureBox.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image Saved Sucessfully...");
            }
        }

        private void OnButtonBackgroundClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*GIF;*PNG)|*.BMP;*.JPG;*GIF;*PNG|ALL FILES (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MainPictureBox.Image = new Bitmap(ofd.FileName);

                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void OnButtonPencilClick(object sender, EventArgs e)
        {
            index = (int)Index.Line;
        }

        private void OnButtonEraserClick(object sender, EventArgs e)
        {
            index = (int)Index.Erase;
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
            _currentAction = DrawText;
        }









        private void DrawStraightLineOrPreview()
        {
            Pen pen = p.Clone() as Pen;
            Point startPoint = new Point(startCursorPosition.X, startCursorPosition.Y);
            Point endPoint = new Point(x, y);
            _onPaintPreview = null;
            if (isPaint)
            {
                
                _onPaintPreview += (graphics) => { graphics.DrawLine(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
            }
            else
            {
                _onPaint += (graphics) => { graphics.DrawLine(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
                
            }

            MainPictureBox.Invalidate();
        }
       
        private void DrawRectangleOrPreview()
        {
            Pen pen = p.Clone() as Pen;
            Point startPoint = new Point(startCursorPosition.X, startCursorPosition.Y);
            Point endPoint = new Point(x, y);
            _onPaintPreview = null;

            if (isPaint)
            {
                _onPaintPreview += (graphics) => { graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
            }
            else
            {
                _onPaint += (graphics) => { graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
            }
            MainPictureBox.Invalidate();
        }
        private void DrawEllipseOrPreview()
        {
            Pen pen = p.Clone() as Pen;
            Point startPoint = new Point(startCursorPosition.X, startCursorPosition.Y);
            Point endPoint = new Point(x, y);
            _onPaintPreview = null;
            if (isPaint)
            {
                _onPaintPreview += (graphics) => { graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
            }
            else
            {
                _onPaint += (graphics) => { graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
            }
            MainPictureBox.Invalidate();
        }

        private void DrawEllipseFillOrPreview()
        {
            Brush brush = b.Clone() as Brush;
            Point startPoint = new Point(startCursorPosition.X, startCursorPosition.Y);
            Point endPoint = new Point(x, y);

            _onPaintPreview = null;
            if (isPaint)
            {
                _onPaintPreview += (graphics) => { graphics.FillEllipse(brush, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
            }
            else
            {
                _onPaint+= (graphics) => { graphics.FillEllipse(brush, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
            }
            MainPictureBox.Invalidate();
        }
        private void DrawText() 
        {
            Brush brush = b.Clone() as Brush;
            Point startPoint = new Point(startCursorPosition.X, startCursorPosition.Y);
            string text = OnTextBox.Text;
            Font font = new Font("Verdana", 30, FontStyle.Italic);

            _onPaintPreview = null;

            //if (OnTextBox.Text == "")
            //{
            //    MessageBox.Show("Ошибка! Для продолжения введите текст в текстовое поле");
            //}


            if (isPaint)
            {
                _onPaintPreview += (graphics) => { graphics.DrawString(text, font, new SolidBrush(newColor), startCursorPosition.X, startCursorPosition.Y); };
            }
            else
            {
                _onPaint += (graphics) => { graphics.DrawString(text, font, new SolidBrush(newColor), startCursorPosition.X, startCursorPosition.Y); };
            }
            MainPictureBox.Invalidate();

        }

        /*-------------------------------------------------------------------------------------------------------------------------*/

        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X*pX), (int)(pt.Y*pY));
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

        

        private void Pens_Load(object sender, EventArgs e)
        {

        }

        private void PensResize(object sender, EventArgs e)
        {
            RoundingPen();
            bm = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
            //g = Graphics.FromImage(bm);
            //g.Clear(Color.White);
            MainPictureBox.Image = bm;
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

            if (isPaint)
            {
                ////конечные координаты
                x = e.X;
                y = e.Y;
                _currentAction?.Invoke();
                
            }     
        }



        
        private void OnPicMouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;
            _currentAction?.Invoke();
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void OnbuttonBackgroundColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            //g.Clear(newColor);
            MainPictureBox.Image = bm;
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






        private void OnPicMouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            startCursorPosition = e.Location;
            //координаты x и y для рисования
            //cX = e.X;
            //cY = e.Y;
        }


        private void OnPaint(object sender, PaintEventArgs e)
        {
            _onPaint?.Invoke(e.Graphics);
            _onPaintPreview?.Invoke(e.Graphics);
        }

    }
}