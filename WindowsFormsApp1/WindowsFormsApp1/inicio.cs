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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // guardando valores del formulario
            string pNombre = textBoxNombre.Text;
            string pRUC = textBoxRUC.Text ;
            string pDireccion = textBoxDireccion.Text;
            int pAnio = int.Parse(textBoxAnio.Text);
            int pMes = int.Parse(textBoxMes.Text);
            string pRegimenTri = textBoxRegimenTri.Text;
            string pLibrosElectronicos = textBoxLibrosElectronicos.Text;
            
            //crear empresa con el boton registrar creando un obj Empresa
            Empresa NuevaEmpresa = new Empresa(pNombre,pRUC,pDireccion,pAnio,pMes,pRegimenTri,pLibrosElectronicos);
            //validar datos de entrada
            if(NuevaEmpresa.Validar())
            {
                MessageBox.Show("Empresa Guardada");
                //debemos crear un modulo para buscar si esta empresa ya esta en la base de datos

                //de no estar registrado debemos guardar y mostrar en la lista de empresas en la base de datos

                //puto el que lo lea :v
            }
            else
            {
                MessageBox.Show("Hay campos sin llenar");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
