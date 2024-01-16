using System.Windows.Forms;

namespace G19_20240110
{
    internal class Program
    {
        static Form form = new Form();
        static void Main(string[] args)
        {
            FormHandler formHandler = new FormHandler();
            ButtonHandler buttonHandler = new ButtonHandler();
            MathOperations math = new MathOperations();
            TextBox textBox = formHandler.CreateTextBox(form);

            formHandler.CreateForm(form);

            buttonHandler.Button0(form);
            buttonHandler.Button1(form);
            buttonHandler.Button2(form);
            buttonHandler.Button3(form);
            buttonHandler.Button4(form);
            buttonHandler.Button5(form);
            buttonHandler.Button6(form);
            buttonHandler.Button7(form);
            buttonHandler.Button8(form);
            buttonHandler.Button9(form);

            buttonHandler.Add(form);
            buttonHandler.Substract(form);
            buttonHandler.Multiply(form);
            buttonHandler.Divide(form);

            buttonHandler.Delete(form);
            buttonHandler.Dot(form);
            buttonHandler.Equal(form);
            buttonHandler.DeleteAll(form);
            
            math.AttachButtonClickHandlers(form, textBox);

            Application.EnableVisualStyles();
            Application.Run(form);
        }
    }
}
