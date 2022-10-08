using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica.Libreria
{
    public class TextBoxEvent
    {
        public void primerLetraMayus(TextBox textBox,KeyPressEventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            }
            else
            {
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
            }
        }
        public void textKeyPress(KeyPressEventArgs e)
        { //Validar campos del tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void numberKeyPress(KeyPressEventArgs e)
        { //Validar campos del tipo numerico
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled= true;
            }
        }

        public void numberDecimalKeyPress(KeyPressEventArgs e)
        { //Validar campos del tipo numerico
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        public bool validateEmail(String email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }

    }
}
