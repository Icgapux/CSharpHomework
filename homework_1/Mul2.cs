using System;
using System.Windows.Forms;
using System.Drawing;
namespace Mul {
    public class MulForm:Form {
        TextBox text = new TextBox();
        Button btn = new Button();
        Label label = new Label();
        public void init() {
            this.Controls.Add(text);
            this.Controls.Add(btn);
            this.Controls.Add(label);
            text.Location = new Point(20, 20);
            btn.Location = new Point(20, 50);
            label.Location = new Point(20, 100);
            this.Size = new Size(200, 200);
            btn.Click += new System.EventHandler(this.buttonClick);
            btn.Text = "Mul them!";
        }
        private void buttonClick(object sender, EventArgs e) {
            string[] tokens = text.Text.Split();
            label.Text = "Ans = " + (int.Parse(tokens[0]) * int.Parse(tokens[1]));
        }
    }
    public class Mul {
        static void Main() {
            MulForm f = new MulForm();
            f.Text = "Mul two numbers";
            f.init();
            Application.Run(f);
        }
    }
}
