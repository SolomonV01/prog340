/*Gabrielle Vidal
 * Prog 340
 * Credits: Microsoft Learn (DrawPolygon)
 */


namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.AliceBlue);
            Brush brush = new SolidBrush(Color.BlueViolet);

            //body / rectangle
            g.FillRectangle(brush, 130, 250, 150, 300);
            g.DrawRectangle(pen, 130, 250, 150, 300);

            //head and hair / circle and square
            SolidBrush headBrush = new SolidBrush(Color.Beige);
            g.FillRectangle(brush, 20, 20, 70, 70);
            g.DrawRectangle(pen, 20, 20, 70, 70);

            g.FillRectangle(brush, 70, 70, 80, 80);
            g.DrawRectangle(pen, 70, 70, 80, 80);

            g.FillRectangle(brush, 200, 20, 70, 70);
            g.DrawRectangle(pen, 200, 20, 70, 70);

            g.FillRectangle(brush, 250, 70, 80, 80);
            g.DrawRectangle(pen, 250, 70, 80, 80);

            g.DrawEllipse(pen, 100, 100, 200, 200);
            g.FillEllipse(headBrush, 100, 100, 200, 200);

            //eyes / arcs
            Pen blackPen = new Pen(Color.Black);
            Rectangle rect = new Rectangle(100, 200, 100, 100);
            float angleOne = 220.0F;
            float angleTwo = 100.0F;
            g.DrawArc(blackPen, rect, angleOne, angleTwo);

            Rectangle rectt = new Rectangle(200, 200, 100, 100);
            float angleOneOne = 220.0F;
            float angleTwoTwo = 100.0F;
            g.DrawArc(blackPen, rectt, angleOneOne, angleTwoTwo);

            Rectangle recttt = new Rectangle(150, 180, 100, 100);
            float angleLast = 30.0F;
            float angleLasts = 100.0F;
            g.DrawArc(blackPen, recttt, angleLast, angleLasts); 

            //triangle
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Point[] tPoints = { new Point(110, 230), new Point(130, 230), new Point(120, 450) };
            g.FillPolygon(whiteBrush, tPoints);
            g.DrawPolygon(blackPen, tPoints);

            //hands / ellipses 
            SolidBrush handsBrush = new SolidBrush(Color.Beige);
            g.DrawEllipse(blackPen, 70, 250, 100, 120);
            g.FillEllipse(handsBrush, 70, 250, 100, 120);

            g.DrawEllipse(blackPen, 240, 250, 100, 120);
            g.FillEllipse(handsBrush, 240, 250, 100, 120);

            //pies
            Pen pinkPen = new Pen(Color.LightPink);
            SolidBrush pinkBrush = new SolidBrush(Color.Magenta);
            Rectangle rectA = new Rectangle(130, 100, 250, 250);
            float angleA = 10.0F;
            float angleB = 55.0F;
            g.DrawPie(pinkPen, rectA, angleA, angleB);
            g.FillPie(pinkBrush, rectA, angleA, angleB);

            Rectangle rectAB = new Rectangle(420, 150, 250, 250);
            float angleAB = 200.0F;
            float angleBB = 300.0F;
            g.DrawPie(pinkPen, rectAB, angleAB, angleBB);
            g.FillPie(pinkBrush, rectAB, angleAB, angleBB);

            //text
            SolidBrush textBrush = new SolidBrush(Color.BlueViolet);
            Rectangle textR = new Rectangle(380, 80, 400, 400);
            Font textFont = new Font("Jokerman", 20);
            string textString = "Pie Day the Pi-teenth";
            g.DrawString(textString, textFont, textBrush, textR);

            SolidBrush whiteTextBrush = new SolidBrush(Color.White);
            Rectangle textRe = new Rectangle(290, 245, 300, 300);
            Font textREFont = new Font("Jokerman", 12);
            string textREString = "Start\nGame";
            g.DrawString(textREString, textREFont, whiteTextBrush, textRe);

            //hexagon
            Pen hexPen = new Pen(Color.White);
            SolidBrush hexBrush = new SolidBrush(Color.Black);
            Point[] hPoints = { new Point(190, 350), new Point(220, 350), new Point(240, 370), new Point(220, 390), new Point(190, 390), new Point(170, 370) };
            g.FillPolygon(hexBrush, hPoints);
            g.DrawPolygon(hexPen, hPoints);
        }
    }
}