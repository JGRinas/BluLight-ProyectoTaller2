using CapaPresentacion.CapaData.Model;
using CapaLogica.Libreria;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica.LVendedor
{
    public class LClient : Librerias
    {
       /* public void registerClient(List<TextBox> listProduct)
        {
            bool validation = true;

            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].Text.Equals(""))
                {
                    validation = false;
                }
            }


            if (validation)
            {
                var codProductValidate = _Client.Where(u => u.dni.Equals(Int32.Parse(listProduct[2].Text))).ToList();
                var codProductValidate2 = _Client.Where(u => u.nMember.Equals(Int32.Parse(listProduct[4].Text))).ToList();
                if (codProductValidate.Count.Equals(0) && codProductValidate2.Count.Equals(0))
                {
                    BeginTransactionAsync();
                    try
                    {
                        
                        _Client.Value(e => e.name, listProduct[0].Text)
                            .Value(e => e.surname, listProduct[1].Text)
                            .Value(e => e.dni, Int32.Parse(listProduct[2].Text))
                            .Value(e => e.address, listProduct[3].Text)
                            .Value(e => e.nMember, Int32.Parse(listProduct[4].Text))
                            .Value(e => e.phone, Int32.Parse(listProduct[5].Text))
                            .Insert();

                        CommitTransaction();
                        for (int i = 0; i < listProduct.Count; i++)
                        {
                            listProduct[i].Text = "";

                        }
                        MessageBox.Show("Usuario registrado correctamente!", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        RollbackTransaction();
                    }
                }
                else
                {
                    if (codProductValidate2.Count > 0)
                    {
                        MessageBox.Show("Numero de socio ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (codProductValidate.Count > 0)
                    {
                        MessageBox.Show("DNI de socio ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }*/
    }
}
