using System.Windows.Forms;

namespace G19_20240110
{
    internal class MathOperations
    {
        private double currentNumber = 0;
        string currentOperation;

        public void AttachButtonClickHandlers(Form form, TextBox textBox)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button button)
                {
                    button.Click += (sender, e) => UpdateTextBox(button.Text, textBox);
                }
            }
        }

        public double Calculate(double firstNumber, double secondNumber, string operation)
        {
            switch (operation)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "×":
                    return firstNumber * secondNumber;
                case "÷":
                    return firstNumber / secondNumber;
                default:
                    return -1;
            }
        }

        private void UpdateTextBox(string buttonText, TextBox textBox)
        {

            switch (buttonText)
            {
                case "+":
                case "-":
                case "×":
                case "÷":



                    if (!string.IsNullOrEmpty(currentOperation))
                    {
                        currentOperation = buttonText;
                    }

                    else if (double.TryParse(textBox.Text, out double parsedNumber))
                    {
                        currentNumber = parsedNumber;
                        currentOperation = buttonText;
                        textBox.Text = "";
                    }

                    break;

                case "=":

                    if (string.IsNullOrEmpty(currentOperation))
                    {
                        currentOperation = buttonText;

                    }
                    else
                    {
                        try
                        {
                            double secondNumber = double.Parse(textBox.Text);
                            double result = Calculate(currentNumber, secondNumber, currentOperation);
                            textBox.Text = result.ToString();
                            currentOperation = "";
                        }
                        catch (System.Exception)
                        {
                       
                        }
                    }

                    break;

                case "C":

                    textBox.Text = "0";
                    currentNumber = 0;
                    currentOperation = "";
                    break;


                case "Del":

                    if (textBox.Text.Length > 0)
                    {
                        textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    }
                    break;

                case ".":

                    if (!textBox.Text.Contains("."))
                    {
                        textBox.Text += ".";
                    }
                    break;


                default:
                    if (textBox.Text == "0")
                    {
                        textBox.Text = buttonText;
                    }
                    else
                    {
                        textBox.Text += buttonText;
                    }

                    break;
            }
        }
    }
}
