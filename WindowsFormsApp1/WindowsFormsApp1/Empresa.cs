using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Empresa
    {
        private string aNombre;
        private string aRUC;
        private string aDireccion;
        private int aAnio;
        private int aMes;
        private string aRegimenTri;
        private string aLibrosElectronicos;
        
        public string Nombre { get; set; }
        public string RUC { get; set; }
        public string Direccion { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public string RegimenTri { get; set; }
        public string LibrosElectronicos { get; set; }

        public Empresa()
        {
            aNombre = "";
            aRUC = "";
            aDireccion = "";
            aAnio = -1;
            aMes = -1;
            aRegimenTri = "";
            aLibrosElectronicos = "";
        }
        public Empresa(string pNombre, string pRUC, string pDireccion, int pAnio, int pMes, string pRegimenTri, string pLibrosElectronicos)
        {
            aNombre = pNombre;
            aRUC = pRUC;
            aDireccion = pDireccion;
            aAnio = pAnio;
            aMes = pMes;
            aRegimenTri = pRegimenTri;
            aLibrosElectronicos = pLibrosElectronicos;
        }
        public Boolean Validar()
        {
            Boolean Res = true;
            if (aNombre == "") { Res = false; }
            if (aRUC == "") { Res = false; }
            if (aDireccion == "") { Res = false; }
            if (aRegimenTri == "") { Res = false; }
            if (aLibrosElectronicos == "") { Res = false; }
            if (aAnio == -1) { Res = false; }
            if (aMes == -1) { Res = false; }
            return Res;
        }

    }
}
