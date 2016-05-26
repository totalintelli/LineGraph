using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 제목 글자열
            string Title = "월별 책의 판매량";
            // 제목의 폰트
            Font TitleFont = new Font("SansSerif", 18);
            // 제목의 색상
            SolidBrush TitleBrush = new SolidBrush(Color.Blue);
            // 제목의 위치
            PointF TitlePoint = new PointF(panel1.Width / 2.0f, 0); // 1/ 2.0f는 제목의 위치를 정하기 위한 값으로 고정값.
            // Y축 글자열
            // (만 권)
            string KwanText = "(만 권)";
            // (만 권)의 색상
            SolidBrush TextBrush = new SolidBrush(Color.Teal);
            // (만 권)의 위치
            PointF KwanTextPoint = new PointF(panel1.Width / 8.0f, panel1.Height / 11.0f);
            // 60
            string SixtyText = "60";
            // 60의 위치
            PointF SixtyTextPoint = new PointF(panel1.Width * 3 / 16.0f, panel1.Height * 2 / 11.0f);
            // 50
            string FiftyText = "50";
            // 50의 위치
            PointF FiftyTextPoint = new PointF(panel1.Width * 3 / 16.0f, panel1.Height * 3 / 11.0f);

            // 제목을 그린다.
            e.Graphics.DrawString(Title, TitleFont, TitleBrush, TitlePoint);

            // (만 권)을 그린다.
            e.Graphics.DrawString(KwanText, TitleFont, TextBrush, KwanTextPoint);

            // 60을 그린다.
            e.Graphics.DrawString(SixtyText, TitleFont, TextBrush, SixtyTextPoint);

            // 50을 그린다.
            e.Graphics.DrawString(FiftyText, TitleFont, TextBrush, FiftyTextPoint);
        }
    }
}
