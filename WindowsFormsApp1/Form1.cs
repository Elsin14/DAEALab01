using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ComboBox comboBox1, comboBox2;
        private string Vnombre, Vdni, Vapellido, Vdireccion, Vtelefono, Vemail, VfecNac, Vdepartamento;
        public Form1()
        {
            InitializeComponent();
            this.comboBox1 = fecNac;
            this.comboBox2 = departamento;
            this.comboBox1.Items.AddRange(new string[] {
                "miercoles, 16 de marzo",
                "jueves, 17 de marzo",
                "viernes, 18 de marzo"});
            this.comboBox2.Items.AddRange(new string[] {
                "Lima",
                "Ayacucho",
                "Trujillo",
                "Piura"
            });
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Vnombre = txtNombre.Text;
            this.Vdni = txtDNI.Text;
            this.Vapellido = txtApellido.Text;
            this.Vdireccion = txtDireccion.Text;
            this.Vtelefono = txtTelefono.Text;
            this.Vemail = txtEmail.Text;
            this.VfecNac = fecNac.Text;
            this.Vdepartamento = departamento.Text;

            dataGridView1.Rows.Add(codigo.Text, Vdni, Vnombre, Vapellido, Vdireccion, Vtelefono, Vemail, VfecNac, Vdepartamento);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

    }
}
