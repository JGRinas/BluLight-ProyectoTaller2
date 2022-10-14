using CapaLogica.Libreria;
using CapaPresentacion.CapaData.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica.LAdmin
{
    public class LUsuariosA : Librerias
    {
        public void comboBoxTiposUsuario(ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (var item in db.Perfil_de_usuario)
                {
                    comboBox.Items.Add(item.idPerfil + " - " + item.perfil);
                }
            }

        }
        public void rellenarDataGridEmpleado(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Empleado> empleados = new List<Empleado>();

                empleados = db.Empleado.ToList();

                if (empleados.Count > 0)
                {
                    foreach (Empleado empleado in empleados)
                    {
                        if (empleado.activo)
                        {
                            var activo = "-";
                            int fila = dataGrid.Rows.Add();

                            var usuario = db.Usuario.Where(u => u.idEmpleado.Equals(empleado.idEmpleado));
                            var esUsuario = "";
                           
                            var nombreDeUsuario = " - ";
                            var tipoPerfil = " - ";
                            if (usuario.ToList().Count > 0)
                            {
                                esUsuario = "Si";

                                nombreDeUsuario = usuario.FirstOrDefault().usuario1;
                                tipoPerfil = usuario.FirstOrDefault().Perfil_de_usuario.perfil;

                                if (usuario.FirstOrDefault().activo)
                                {
                                    activo = "Si";
                                    dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;
                                }
                                else
                                {
                                    activo = "No";
                                    dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;
                                }
                            }
                            else esUsuario = "No";



                            dataGrid.Rows[fila].Cells["ColumnActivo"].Value = activo;
                            dataGrid.Rows[fila].Cells["ColumnName"].Value = empleado.Persona.nombre;
                            dataGrid.Rows[fila].Cells["ColumnSurname"].Value = empleado.Persona.apellido;
                            dataGrid.Rows[fila].Cells["ColumnDni"].Value = empleado.Persona.dni;
                            dataGrid.Rows[fila].Cells["ColumnUsuario"].Value = esUsuario;
                            dataGrid.Rows[fila].Cells["ColumnNombreUsuario"].Value = nombreDeUsuario;
                            dataGrid.Rows[fila].Cells["ColumnTipoDePerfil"].Value = tipoPerfil;
                        }
                        
                    }
                }
            }
        }


        private int dniNuevoUsuario;
        public void buscarEmpleado(List<Label> listLabels, int dni, Button buttonRegistrarUsuario, List<TextBox> textboxes, ComboBox comboBox)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (Label list in listLabels)
                {
                    list.Text = "";
                }

                foreach (TextBox textBox in textboxes)
                {
                    textBox.Text = "";
                }

                Empleado empleados = new Empleado();

                var personaE = db.Empleado.Where(b => b.Persona.dni.Equals(dni));

                if (personaE.ToList().Count > 0 && personaE.FirstOrDefault().activo)
                {
                    dniNuevoUsuario = dni;
                    empleados = personaE.FirstOrDefault();

                    var lab = "No corresponde";
                    if (empleados.idLab != null)
                    {
                        lab = empleados.Laboratorio.nombre;
                    }

                    listLabels[0].Text = empleados.Persona.nombre + " " + empleados.Persona.apellido;
                    listLabels[1].Text = empleados.Persona.dni.ToString();
                    listLabels[2].Text = empleados.maxTitulo;
                    listLabels[3].Text = lab;
                    listLabels[4].Text = empleados.Persona.telefono.ToString();
                    listLabels[5].Text = empleados.Persona.email;


                    var usuario = db.Usuario.Where(u => u.Empleado.Persona.dni.Equals(dni));
                    if (usuario.ToArray().Length > 0)
                    {
                        buttonRegistrarUsuario.Text = "Modificar";
                        textboxes[0].Text = usuario.First().usuario1;
                        comboBox.SelectedIndex = usuario.First().idPerfil - 1;
                    }
                    else
                    {
                        buttonRegistrarUsuario.Text = "Registrar";
                    }
                    buttonRegistrarUsuario.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Empleado inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void registrarUsuario(List<TextBox> textBoxes, ComboBox comboBoxPerfiles, List<Label> listLabels, Button buttonRegistrar)
        {
            bool validate = true;

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == "")
                {
                    validate = false;
                }
            }
            if (comboBoxPerfiles.SelectedIndex == -1)
            {
                validate = false;
            }


            if (validate)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var usuario = textBoxes[0].Text;
                    var userValidate = from p in db.Usuario where p.usuario1 == usuario select p;

                    if (userValidate.ToArray().Length > 0)
                    {
                        MessageBox.Show("Usuario ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Usuario usuarioEmpleado = new Usuario();

                        var sPass = Encrypt.GetSHA256(textBoxes[1].Text);

                        var idEmpleado = db.Empleado.Where(e => e.Persona.dni.Equals(dniNuevoUsuario)).ToList();

                        usuarioEmpleado.usuario1 = usuario;
                        usuarioEmpleado.password = sPass;
                        usuarioEmpleado.idPerfil = comboBoxPerfiles.SelectedIndex + 1;
                        usuarioEmpleado.idEmpleado = idEmpleado[0].idEmpleado;
                        usuarioEmpleado.activo = true;

                        db.Usuario.Add(usuarioEmpleado);
                        db.SaveChanges();

                        MessageBox.Show("Empleado agregado con exito", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (TextBox textBox in textBoxes)
                        {
                            textBox.Text = "";
                        }

                        foreach (Label label in listLabels)
                        {
                            label.Text = "";
                        }
                        comboBoxPerfiles.SelectedIndex = -1;
                        buttonRegistrar.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void modificarUsuario(List<TextBox> textBoxes, ComboBox comboBoxPerfiles, List<Label> listLabels, Button buttonRegistrar)
        {
            bool validate = true;

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == "")
                {
                    validate = false;
                }
            }
            if (comboBoxPerfiles.SelectedIndex == -1)
            {
                validate = false;
            }


            if (validate)
            {
                using (bd_blulightEntities db = new bd_blulightEntities())
                {
                    var usuario = textBoxes[0].Text;
                    var userValidate = from p in db.Usuario where p.usuario1 == usuario select p;
                    var userValidate2 = db.Usuario.Where(u => u.Empleado.Persona.dni.Equals(dniNuevoUsuario)).FirstOrDefault();
                    if (userValidate2.usuario1.Equals(usuario) || userValidate.ToArray().Length <= 0)
                    {

                        Usuario usuarioEmpleado = new Usuario();

                        var sPass = Encrypt.GetSHA256(textBoxes[1].Text);

                        var empleadoUsuario = db.Usuario.SingleOrDefault(e => e.Empleado.Persona.dni.Equals(dniNuevoUsuario));

                        empleadoUsuario.usuario1 = usuario;
                        empleadoUsuario.password = sPass;
                        empleadoUsuario.idPerfil = comboBoxPerfiles.SelectedIndex + 1;

                        db.SaveChanges();

                        MessageBox.Show("Usuario modificado con éxito", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (TextBox textBox in textBoxes)
                        {
                            textBox.Text = "";
                        }

                        foreach (Label label in listLabels)
                        {
                            label.Text = "";
                        }

                        comboBoxPerfiles.SelectedIndex = -1;
                        buttonRegistrar.Enabled = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario ya registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * ELIMINAR O RESTAURAR USUARIOS
         */

        public void rellenarDataGridEmpleadoEliminar(DataGridView dataGrid)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                List<Usuario> usuarios = new List<Usuario>();

                usuarios = db.Usuario.ToList();

                if (usuarios.Count > 0)
                {
                    foreach (Usuario usuario in usuarios)
                    {
                        var activo = "";
                        int fila = dataGrid.Rows.Add();
                        if (usuario.activo)
                        {
                            activo = "Si";
                            dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.White;
                        }
                        else
                        {
                            activo = "No";
                            dataGrid.Rows[fila].DefaultCellStyle.BackColor = Color.Gray;
                        }

                        dataGrid.Rows[fila].Cells["ColumnActivo"].Value = activo;
                        dataGrid.Rows[fila].Cells["ColumnName"].Value = usuario.Empleado.Persona.nombre;
                        dataGrid.Rows[fila].Cells["ColumnSurname"].Value = usuario.Empleado.Persona.apellido;
                        dataGrid.Rows[fila].Cells["ColumnDNIU"].Value = usuario.Empleado.Persona.dni.ToString();
                        dataGrid.Rows[fila].Cells["ColumnNombreUsuario"].Value = usuario.usuario1;
                        dataGrid.Rows[fila].Cells["ColumnTipoDePerfil"].Value = usuario.Perfil_de_usuario.perfil;
                    }
                }
            }
        }

        public void buscarUsuario(List<Label> listLabels, int dni, Button buttonEliminarUsuario)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                foreach (Label list in listLabels)
                {
                    list.Text = "";
                }
                
                var usuario = db.Usuario.Where(b => b.Empleado.Persona.dni.Equals(dni)).ToList();

                if (usuario.Count > 0)
                {

                    listLabels[0].Text = usuario[0].Empleado.Persona.nombre + " " + usuario[0].Empleado.Persona.apellido;
                    listLabels[1].Text = usuario[0].Empleado.Persona.dni.ToString();
                    listLabels[2].Text = usuario[0].usuario1;
                    listLabels[3].Text = usuario[0].Perfil_de_usuario.perfil;

                    if (usuario[0].activo)
                    {
                        buttonEliminarUsuario.Text = "Eliminar";
                    }
                    else
                    {
                        buttonEliminarUsuario.Text = "Restaurar";
                    }

                    buttonEliminarUsuario.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Empleado inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void eliminarUsuario(int dni, List<Label> listLabels)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (MessageBox.Show("Estas seguro de que desea eliminar el usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    if (db.Usuario.Where(e => e.Empleado.Persona.dni.Equals(dni)).ToList().Count > 0)
                    {
                        var activo = db.Usuario.SingleOrDefault(e => e.Empleado.Persona.dni.Equals(dni));

                        activo.activo = false;
                        MessageBox.Show("Usuario eliminado", "Eliminar Usuario", MessageBoxButtons.OK);

                        db.SaveChanges();

                        foreach (Label label in listLabels)
                        {
                            label.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Usuario No Existe", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        public void restaurarUsuario(int dni, List<Label> listLabels)
        {
            using (bd_blulightEntities db = new bd_blulightEntities())
            {
                if (MessageBox.Show("Estas seguro de que desea restaurar el usuario?", "Restaurar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {

                    if (db.Usuario.Where(e => e.Empleado.Persona.dni.Equals(dni)).ToList().Count > 0)
                    {
                        var activo = db.Usuario.SingleOrDefault(e => e.Empleado.Persona.dni.Equals(dni));

                        activo.activo = true;
                        MessageBox.Show("Usuario restaurado", "Restaurar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        db.SaveChanges();

                        foreach (Label label in listLabels)
                        {
                            label.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Usuario No Existe", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
