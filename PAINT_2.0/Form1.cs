using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Reflection;
using System.Windows.Input;


namespace PAINT_2._0
{

    public delegate void RoundDelegate();
    public partial class Form1 : Form
    {
        /// <summary>
        /// Делегат хранящий отрисованные обьекты
        /// </summary>
        private Action<Graphics> _onPaint;

        /// <summary>
        /// Делегат хранящий объект для предпросмотра
        /// </summary>
        private Action<Graphics> _onPaintPreview;

        /// <summary>
        /// Делегат хранящий текущее действие
        /// </summary>
        private Action _currentAction;
     

        public Form1()
        {
            InitializeComponent();
            Rounding();
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
        bool isPaint = false;

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
        
        int x, y, sX, sY, cX, cY;

        
        /// <summary>
        /// Представляет общее диалоговое окно, в котором отображаются доступные цвета и элементы управления, 
        /// позволяющие пользователю определять собственные цвета.
        /// </summary>
        ColorDialog colorDialog = new ColorDialog();

        Color newColor;



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

        //
        private void OnButtonColorClick(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            newColor = colorDialog.Color;
            picture_color.BackColor = colorDialog.Color;
            p.Color = colorDialog.Color;
            b = new SolidBrush(newColor);
        }

        private void OnButtonFillClick(object sender, EventArgs e)
        {
            //index = (int)Index.Fill;
            _currentAction = Filling;
        }

        private void OnPicMouseClick(object sender, MouseEventArgs e)
        {
            if (_currentAction == Filling)
            {
                Point point = SetPoint(MainPictureBox, e.Location);
                Fill(bm, point.X, point.Y, newColor);
                _currentAction?.Invoke();
                
            }
            MainPictureBox.Invalidate();
        }

        /// <summary>
        /// Сохранение изображения
        /// </summary>
        private void OnButtonSaveClick(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(MainPictureBox.Width);
                int height = Convert.ToInt32(MainPictureBox.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    MainPictureBox.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("Image Saved Sucessfully...");
                }
            }
        }

        private void OnButtonBackgroundClick(object sender, EventArgs e)
        {
            _currentAction += Background;
            _currentAction.Invoke();
        }

        void Background()
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
            _currentAction = DrawLine;
        }

        private void OnButtonEraserClick(object sender, EventArgs e)
        {
            _currentAction = Erase;
        }



        private void OnButtonEllipseFillClick(object sender, EventArgs e)
        {
            _currentAction = DrawEllipseFillOrPreview;
        }


        private void OnButtonRectangleFillClick(object sender, EventArgs e)
        {
            _currentAction = DrawFillRectangleOrPreview;
        }

        private void OnButtonTextClick(object sender, EventArgs e)
        {
            _currentAction = DrawText;
        }

        private void Filling()
        {

        }

        private void Erase()
        {
            Point startPoint = new Point(px.X, px.Y);
            Point endPoint = new Point(py.X, py.Y);
            Pen pen = erase.Clone() as Pen;

            _onPaintPreview = null;

            _onPaint += (graphics) => { graphics.DrawLine(pen, startPoint, endPoint); };

            MainPictureBox.Invalidate();
        }


        private void DrawLine()
        {

            Pen pen = p.Clone() as Pen;
            Point startPoint = new Point(px.X, px.Y);
            Point endPoint = new Point(py.X, py.Y);

            _onPaintPreview = null;

            _onPaint += (graphics) => { graphics.DrawLine(pen, startPoint, endPoint); };   

            MainPictureBox.Invalidate();
        }



        private void DrawStraightLineOrPreview()
        {
            Pen pen = p.Clone() as Pen;
            Point startPoint = new Point(py.X, py.Y);
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
            Point startPoint = new Point(cX, cY);
            Point endPoint = new Point(sX, sY);
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
            Point startPoint = new Point(cX, cY);
            Point endPoint = new Point(sX, sY);
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
            Point startPoint = new Point(cX, cY);
            Point endPoint = new Point(sX, sY);
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

        private void DrawFillRectangleOrPreview()
        {
            Brush brush = b.Clone() as Brush;
            Point startPoint = new Point(cX, cY);
            Point endPoint = new Point(sX, sY);
            _onPaintPreview = null;
            if (isPaint)
            {
                _onPaintPreview += (graphics) => { graphics.FillRectangle(brush, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
            }
            else
            {
                _onPaint += (graphics) => { graphics.FillRectangle(brush, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y); };
            }
            MainPictureBox.Invalidate();
        }
        private void DrawText() 
        {
            Brush brush = b.Clone() as Brush;
            Point startPoint = new Point(cX, cY);
            string text = OnTextBox.Text;
            Font font = new Font("Verdana", 30, FontStyle.Italic);

            _onPaintPreview = null;

            if (OnTextBox.Text == "")
            {
                MessageBox.Show("Ошибка! Для продолжения введите текст в текстовое поле");
            }

                _onPaint += (graphics) => { graphics.DrawString(text, font, new SolidBrush(newColor), startPoint.X, startPoint.Y); };
      
                MainPictureBox.Invalidate();
    
            

        }



        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X*pX), (int)(pt.Y*pY));
        }



        /// <summary>
        /// Отображение выбранного цвета на кнопке picture_color
        /// и смена цвета у экземпляра класса Pen, Brush
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        


        /// <summary>
        /// Толщина фигур, рисуемых с помощью класса Pen
        /// </summary>
        private void OnTrackBarPenValueChanged(object sender, EventArgs e)
        {
            p.Width = trackBarPen.Value;
        }

        /// <summary>
        /// Толщина стерки
        /// </summary>
        private void OnTrackBarEraserValueChanged(object sender, EventArgs e)
        {
            erase.Width = trackBarEraser.Value;
        }

        private void OnPicMouseMove(object sender, MouseEventArgs e)
        {

            if (isPaint)
            {
                x = e.X;
                y = e.Y;
                sX = e.X - cX;
                sY = e.Y - cY;

                if (_currentAction == DrawLine || _currentAction== Erase)
                {
                    px = e.Location;
                    _currentAction?.Invoke();
                    py = px;
                }
                else
                {
                    _currentAction?.Invoke();
                }
               
            }     
        }



        
        private void OnPicMouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;
            sX = x - cX;
            sY = y - cY;

            _currentAction?.Invoke();
        }

        private void OnbuttonBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            newColor = colorDialog.Color;
            _onPaint+= (graphics) => { graphics.Clear(newColor); };
            MainPictureBox.Image = bm;
        }


        /// <summary>
        /// Скругление линий для рисования карандашем и стеркой
        /// </summary>
        private void Rounding()
        {
            RoundDelegate round = () =>
            {
                p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                erase.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                erase.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            };
            round();
        }




        private void OnPicMouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            py = e.Location;
            
            //координаты x и y для рисования
            cX = e.X;
            cY = e.Y;
        }


        private void OnPaint(object sender, PaintEventArgs e)
        {
            _onPaintPreview?.Invoke(e.Graphics);
            _onPaint?.Invoke(e.Graphics);   
        }

    }
}