using System.Drawing;
using System.Windows.Forms;

namespace G19_20240110
{
    internal class ButtonHandler : MathOperations
    {
        #region -- Numbers --

        public void Button0(Form form)
        {
            Button button = new Button();
            button.Text = "0";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 55);
            button.Location = new Point(83, 454);
            form.Controls.Add(button);
        }
        public void Button1(Form form)
        {
            Button button = new Button();
            button.Text = "1";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 57);
            button.Location = new Point(1, 398);
            form.Controls.Add(button);
        }

        public void Button2(Form form)
        {
            Button button = new Button();
            button.Text = "2";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 57);
            button.Location = new Point(83, 398);
            form.Controls.Add(button);
        }
        public void Button3(Form form)
        {
            Button button = new Button();
            button.Text = "3";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 57);
            button.Location = new Point(166, 398);
            form.Controls.Add(button);
        }
        public void Button4(Form form)
        {
            Button button = new Button();
            button.Text = "4";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 57);
            button.Location = new Point(1, 342);
            form.Controls.Add(button);
        }
        public void Button5(Form form)
        {
            Button button = new Button();
            button.Text = "5";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 57);
            button.Location = new Point(83, 342);
            form.Controls.Add(button);
        }
        public void Button6(Form form)
        {
            Button button = new Button();
            button.Text = "6";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 57);
            button.Location = new Point(166, 342);
            form.Controls.Add(button);
        }
        public void Button7(Form form)
        {
            Button button = new Button();
            button.Text = "7";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 57);
            button.Location = new Point(1, 286);
            form.Controls.Add(button);
        }
        public void Button8(Form form)
        {
            Button button = new Button();
            button.Text = "8";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 57);
            button.Location = new Point(83, 286);
            form.Controls.Add(button);
        }
        public void Button9(Form form)
        {
            Button button = new Button();
            button.Text = "9";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 57);
            button.Location = new Point(166, 286);
            form.Controls.Add(button);
        }

        #endregion

        #region -- Operations --
        public void Add(Form form)
        {
            Button button = new Button();
            button.Text = "+";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(70, 57);
            button.Location = new Point(249, 398);
            form.Controls.Add(button);
        }
        public void Substract(Form form)
        {
            Button button = new Button();
            button.Text = "-";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(70, 57);
            button.Location = new Point(249, 342);
            form.Controls.Add(button);
        }
        public void Multiply(Form form)
        {
            Button button = new Button();
            button.Text = "×";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(70, 57);
            button.Location = new Point(249, 286);
            form.Controls.Add(button);
        }
        public void Divide(Form form)
        {
            Button button = new Button();
            button.Text = "÷";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(70, 57);
            button.Location = new Point(249, 230);
            form.Controls.Add(button);
        }
        public void Delete(Form form)
        {
            Button button = new Button();
            button.Text = "Del";
            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 55);
            button.Location = new Point(1, 454);
            form.Controls.Add(button);
        }

        public void Dot(Form form)
        {
            Button button = new Button();
            button.Text = ".";

            button.Font = new Font(button.Font.FontFamily, 16);
            button.Size = new Size(83, 55);
            button.Location = new Point(166, 454);
            form.Controls.Add(button);
        }
        public void Equal(Form form)
        {
            Button button = new Button();
            button.Text = "=";
            button.Font = new Font(button.Font.FontFamily, 20);
            button.Size = new Size(70, 55);
            button.Location = new Point(249, 454);
            form.Controls.Add(button);
        }
        public void DeleteAll(Form form)
        {
            Button button = new Button();
            button.Text = "C";
            button.Font = new Font(button.Font.FontFamily, 20);
            button.Size = new Size(248, 55);
            button.Location = new Point(1, 231);
            form.Controls.Add(button);
        }
        #endregion
    }
}

