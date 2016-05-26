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
            // 글자의 색상
            SolidBrush TextBrush = new SolidBrush(Color.Teal);
            // 글자의 위치
            PointF KwanTextPoint = new PointF(panel1.Width * 0.1f, panel1.Height * 0.1f);

            // 제목을 그린다.
            e.Graphics.DrawString(Title, TitleFont, TitleBrush, TitlePoint);

            // (만 권)을 그린다.
            e.Graphics.DrawString(KwanText, TitleFont, TextBrush, KwanTextPoint);
        }
    }
}
