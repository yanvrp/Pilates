using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates.YControls
{
    public class YButton : Button
    {
        //Fields
        private int borderSize = 1;
        private int borderRadius = 8;
        private Color borderColor = Color.FromArgb(148, 0, 211);

        //Properties
        [Category("Y Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Y Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Y Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Y Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Y Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public YButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Defina a cor do texto para DarkViolet se o botão estiver desabilitado
            Color textColor = this.Enabled ? this.ForeColor : Color.DarkViolet;

            // Desenhe a superfície do botão
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;

            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) // Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    // Defina a região do botão para aplicar bordas arredondadas
                    this.Region = new Region(pathSurface);

                    // Desenhe o contorno do botão
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Desenhe a borda do botão
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;

                // Defina a região do botão
                this.Region = new Region(rectSurface);

                // Desenhe a borda do botão
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            // Desenhe o texto do botão com a cor apropriada
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, rectSurface, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }


        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);

            if (!this.Enabled)
            {
                this.ForeColor = Color.DarkViolet;
            }
            else
            {
                this.ForeColor = Color.DarkViolet;
            }
            this.Invalidate(); 
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

    }
}
