using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.ComponentModel;

// by conmajia@gmail.com


namespace HD.MyControls
{
    public class TabControlEx : TabControl
    {
        #region Status Variables
        bool mouseDown = false;
        #endregion

        #region Graphics Variables
        private Image icon;
        private Image tabBackground = RenderHelper.GetImageFormResourceStream("ControlExs.TabControls.Image.TabButtonBackground.bmp");
        private Color _backColor = Color.FromArgb(234, 247, 254);
        private ImageAttributes ia;
        private ColorMatrix cm;
        float[][] colorMatrix ={
            new float[]{0.299f, 0.299f, 0.299f, 0, 0},
            new float[]{0.587f, 0.587f, 0.587f, 0, 0},
            new float[]{0.114f, 0.114f, 0.114f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 1, 0}};
        #endregion

        #region Properties

        /// <summary>
        /// 选项卡的图片
        /// </summary>
        [Category("Image"),
         DefaultValue(null),
         Description("选项卡的图片")]
        public Image Image
        {
            get { return tabBackground; }
            set { tabBackground = value; this.Invalidate(); }
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DefaultValue(typeof(Color), "234, 247, 254")]
        public override Color BackColor
        {
            get { return _backColor; }
            set
            {
                _backColor = value;
                base.Invalidate(true);
            }
        }
        #endregion

        #region Initiates
        public TabControlEx()
        {
            setStyles();

            ia = new ImageAttributes();
            cm = new ColorMatrix(colorMatrix);
            ia.SetColorMatrix(cm, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            icon = new Bitmap(1, 1);
        }

        #endregion

        #region Private UI Methods

        private void setStyles()
        {
            base.SetStyle(
                 ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer |
                 ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.ResizeRedraw |
                 ControlStyles.SupportsTransparentBackColor,
                 true);
            base.UpdateStyles();
        }

        // 计算控件底线
        private void setLowBound(Control container)
        {
            int tmp = 0;
            Control c = null;
            for (int i = 0; i < container.Controls.Count; i++)
            {
                c = container.Controls[i];
                if (tmp < c.Bottom)
                    tmp = c.Bottom;
            }

            container.Tag = tmp;
        }
        #endregion

        #region Tab Overrides

        protected override void OnControlAdded(ControlEventArgs e)
        {
            setLowBound(e.Control);
        }

        #endregion

        #region Paint Override

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawDrawBackgroundAndHeader(e.Graphics);

            e.Graphics.TextRenderingHint
                = TextRenderingHint.AntiAlias;

            for (int i = 0; i < this.TabCount; i++)
            {
                if (this.SelectedIndex == i && tabBackground != null)
                    e.Graphics.DrawImage(tabBackground, this.GetTabRect(i));

                if (this.ImageList != null && (this.TabPages[i].ImageIndex > -1 || !string.IsNullOrEmpty(this.TabPages[i].ImageKey)))
                {
                    if (this.TabPages[i].ImageIndex > -1)
                        icon = this.ImageList.Images[this.TabPages[i].ImageIndex];
                    else
                        if (!string.IsNullOrEmpty(this.TabPages[i].ImageKey))
                            icon = this.ImageList.Images[this.TabPages[i].ImageKey];

                    if (mouseDown && (this.SelectedIndex != i))
                        e.Graphics.DrawImage(
                            icon,
                            new Rectangle(
                            this.GetTabRect(i).X + (this.GetTabRect(i).Width - icon.Width) / 2,
                            this.GetTabRect(i).Y,
                            icon.Width,
                            icon.Height),
                            0,
                            0,
                            icon.Width,
                            icon.Height,
                            GraphicsUnit.Pixel,
                            ia);
                    else
                        e.Graphics.DrawImage(
                            icon,
                            this.GetTabRect(i).X + (this.GetTabRect(i).Width - icon.Width) / 2,
                            this.GetTabRect(i).Y);

                }

                SizeF textSize
                    = e.Graphics.MeasureString(this.TabPages[i].Text, this.Font);

                e.Graphics.DrawString(
                    this.TabPages[i].Text,
                    this.Font,
                    SystemBrushes.ControlLightLight,
                    this.GetTabRect(i).X + (this.GetTabRect(i).Width - textSize.Width) / 2 + 1,
                    this.GetTabRect(i).Y + 40);

                e.Graphics.DrawString(
                    this.TabPages[i].Text,
                    this.Font,
                    SystemBrushes.ControlText,
                    this.GetTabRect(i).X + (this.GetTabRect(i).Width - textSize.Width) / 2,
                    this.GetTabRect(i).Y + 39);
            }
        }

        private void DrawDrawBackgroundAndHeader(Graphics g)
        {
            int x = 0;
            int y = 0;
            int width = 0;
            int height = 0;

            switch (Alignment)
            {
                case TabAlignment.Top:
                    x = 0;
                    y = 0;
                    width = ClientRectangle.Width;
                    height = ClientRectangle.Height - DisplayRectangle.Height;
                    break;
                case TabAlignment.Bottom:
                    x = 0;
                    y = DisplayRectangle.Height;
                    width = ClientRectangle.Width;
                    height = ClientRectangle.Height - DisplayRectangle.Height;
                    break;
                case TabAlignment.Left:
                    x = 0;
                    y = 0;
                    width = ClientRectangle.Width - DisplayRectangle.Width;
                    height = ClientRectangle.Height;
                    break;
                case TabAlignment.Right:
                    x = DisplayRectangle.Width;
                    y = 0;
                    width = ClientRectangle.Width - DisplayRectangle.Width;
                    height = ClientRectangle.Height;
                    break;
            }

            Rectangle headerRect = new Rectangle(x, y, width, height);
            Color backColor = Enabled ? _backColor : SystemColors.Control;
            using (SolidBrush brush = new SolidBrush(backColor))
            {
                g.FillRectangle(brush, ClientRectangle);
                g.FillRectangle(brush, headerRect);
            }
        }

        #endregion
    }
}
