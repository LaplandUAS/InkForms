using InkForms.Properties;
using InkForms.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InkForms
{
    public partial class Main : Form
    {
        static readonly float[] _dPattern = { 5, 2, 15, 2 };
        static readonly Font _tFont = new Font("Tahoma", 8F);

        Bitmap _outBuffer;

        Bitmap _background;
        Bitmap _foreground;
        Graphics _bgBuffer;
        Graphics _fgBuffer;
        Pen _line;
        TextureBrush _bgBrush;
        v2d _dim;

        Image _bgTile = Resources.bg_canvasTile;

        void InitializeCanvas()
        {
            _dim = new v2d { X = pb_sceneBuffer.Width, Y = pb_sceneBuffer.Height };
            _outBuffer = new Bitmap(_dim.X, _dim.Y);
            _background = new Bitmap(_dim.X, _dim.Y);
            _foreground = new Bitmap(_dim.X, _dim.Y);
            _bgBuffer = Graphics.FromImage(_background);
            _fgBuffer = Graphics.FromImage(_foreground);
            _fgBuffer.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
            _line = new Pen(Color.Black, 1);
            _line.DashPattern = _dPattern;
            _bgBrush = new TextureBrush(_bgTile);
            DrawBackground();
            Updatecanvas();
        }

        void DrawBackground()
        {
            _bgBuffer.FillRectangle(_bgBrush, new Rectangle(0,0,_dim.X, _dim.Y));
        }
        void DrawForeground(Point Cursor, bool draw)
        {
            _fgBuffer.Clear(Color.Transparent);
            if (!draw)
                return;
            _fgBuffer.DrawString($"X:{Cursor.X}\nY:{Cursor.Y}",_tFont,Brushes.Black,Cursor);
            _fgBuffer.DrawLine(_line, 0, Cursor.Y, _dim.X, Cursor.Y); //Horizontal line
            _fgBuffer.DrawLine(_line, Cursor.X, 0, Cursor.X, _dim.Y); //Vertical line
        }
        void Updatecanvas()
        {
            using (Graphics gfx = Graphics.FromImage(_outBuffer))
            {
                gfx.Clear(Color.Transparent);
                gfx.DrawImage(_background, new Rectangle(0, 0, _dim.X, _dim.Y));
                gfx.DrawImage(_foreground, new Rectangle(0, 0, _dim.X, _dim.Y));
            }

            pb_sceneBuffer.Image = _outBuffer;
            pb_sceneBuffer.Refresh();
        }

        private void pb_sceneBuffer_MouseMove(object sender, MouseEventArgs e)
        {
            DrawForeground(e.Location, true);
            Updatecanvas();
        }
        private void pb_sceneBuffer_MouseLeave(object sender, EventArgs e)
        {
            DrawForeground(Point.Empty, false);
            DrawBackground();
            Updatecanvas();
        }
    }
}
