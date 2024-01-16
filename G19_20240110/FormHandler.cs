using System.Drawing;
using System.Windows.Forms;

namespace G19_20240110
{ 
    internal class FormHandler : ButtonHandler
    { 
        public void CreateForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Text = "Calculator";
            form.Size = new Size(335, 548);

            form.FormBorderStyle = FormBorderStyle.FixedSingle; 
        }
        public TextBox CreateTextBox(Form form)
        {
            TextBox box = new TextBox();
            box.Text = "0";
            box.ReadOnly = true;

            box.Size = new Size(311, 200);
            box.Location = new Point(3, 155);
            box.BorderStyle= BorderStyle.FixedSingle;
            form.Controls.Add(box);
            return box;
        }
    }
}
