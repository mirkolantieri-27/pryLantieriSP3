namespace pryLantieriSP3
{
    public partial class frmRepuestos : Form
    {
        //declaración de variables globales
        //array de 1 dimensión - vector - sin elementos
        string[] vecRegistros;

        //aray de 2 dimensiones - matriz - sin elementos
        string[] matRegistros;

        //array de 1 dimensión - vector
        string[] vecRepuestos = new string[3];

        //array de 2 dimensiones - matriz
        string[,] matRepuestos = new string[2, 2];

        
        public frmRepuestos()
        {
            InitializeComponent();
        }

        string Marca;
        string Origen;
        string Descripcion;
        int Numero;
        int Precio;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbpCarga_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string varMarca = cmbMarca.Text;
            string varOrigen;

            varOrigen = (rdbNacional.Checked == true) ? "Nacional" : "Importado";

            lstRepuestos.Items.Add(varMarca + ' ' + varOrigen );

            //grabar en el vector . array de 1 dimensiòn
            vecRepuestos[0] = "primerdato";
            vecRepuestos[1] = "segundodato";
            vecRepuestos[2] = "tercerdato";
        }

        private void rdbImportado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
