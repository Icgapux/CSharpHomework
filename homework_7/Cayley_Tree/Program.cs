using System;
using System.Drawing;
using System.Windows.Forms;

namespace cayley {
    public class Cayley:Form {
        private void button1_Click(object sender, EventArgs e) {
            if (graphics == null) {
                graphics = this.CreateGraphics();
            }
            // drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
            drawCayleyTree(
                int.Parse(n.Text),
                double.Parse(x0.Text), double.Parse(y0.Text),
                double.Parse(leng.Text), double.Parse(th.Text));
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Button btn = new Button();
        TextBox n = new TextBox();
        TextBox x0 = new TextBox();
        TextBox y0 = new TextBox();
        TextBox leng = new TextBox();
        TextBox th = new TextBox();

        public void drawCayleyTree(int n, double x0, double y0, double leng, double th) {
            if (n == 0) {
                return;
            }

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        public void drawLine(double x0, double y0, double x1, double y1) {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        public void init() {
            this.Controls.Add(btn);
            btn.Text = "Draw";
            this.Size = new Size(1000, 600);
            btn.Click += new System.EventHandler(this.button1_Click);
            btn.Size = new Size(40, 20);
            btn.Location = new Point(50, 20);

            this.Controls.Add(n);
            n.Location = new Point(100, 20);
            n.Size = new Size(40, 20);

            this.Controls.Add(x0);
            x0.Location = new Point(150, 20);
            x0.Size = new Size(40, 20);

            this.Controls.Add(y0);
            y0.Location = new Point(200, 20);
            y0.Size = new Size(40, 20);

            this.Controls.Add(leng);
            leng.Location = new Point(250, 20);
            leng.Size = new Size(40, 20);

            this.Controls.Add(th);
            th.Location = new Point(300, 20);
            th.Size = new Size(40, 20);
        }

        /// <summary>
        ///   The main entry point for the application
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            Cayley c = new Cayley();
            c.Text = "Draw a cayley tree.";
            c.init();
            Application.Run(c);
        }
    }
}
