using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Entity.model;
using Entity;
using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboBox();
                CargarsDataGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        List<AplicacionEntity> aplicacionesBorrador = new List<AplicacionEntity>();
        AplicacionBusiness aplicacionBusiness = new AplicacionBusiness();
        CategoriaBusiness categoriaBusiness = new CategoriaBusiness();

        private void btnAñadirAplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                AplicacionEntity app = new AplicacionEntity
                {
                    Titulo = txtTitulo.Text,
                    Descripcion = txtDescripcion.Text,
                    Desarrolladora = txtDesarrolladora.Text,
                    Precio = Convert.ToDouble(txtPrecio.Text),
                    Categoria = new CategoriaEntity
                    {
                        Id = Convert.ToInt32(cbCategoria.SelectedValue)
                    }
                };
                aplicacionesBorrador.Add(app);
                MessageBox.Show("Aplicacion añadida al borrador");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtTitulo.Text = "";
                txtDescripcion.Text = "";
                txtDesarrolladora.Text = "";
                txtPrecio.Text = "";
                cbCategoria.Text = "";
                CargarsDataGrid();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                aplicacionBusiness.CargarAplicacion(aplicacionesBorrador);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CargarComboBox()
        {
            try
            {
                List<CategoriaEntity> categorias = categoriaBusiness.ObtenerCategorias();
                cbCategoria.DataSource = null;
                cbCategoria.DataSource = categorias;
                cbCategoria.DisplayMember = "Descripcion";
                cbCategoria.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                AplicacionEntity app = new AplicacionEntity
                {
                    Titulo = txtNuevoTitulo.Text,
                    Descripcion = txtNuevaDescripcion.Text,
                    Desarrolladora = txtNuevaDesarrolladora.Text,
                    Precio = Convert.ToDouble(txtNuevoPrecio.Text),
                };
                aplicacionBusiness.ModificarAplicacion(app, Convert.ToInt32(txtIdMod.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtNuevoTitulo.Text = "";
                txtNuevaDescripcion.Text = "";
                txtNuevaDesarrolladora.Text = "";
                txtNuevoPrecio.Text = "";
                CargarsDataGrid();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                aplicacionBusiness.EliminarAplicacion(Convert.ToInt32(txtIdEliminar.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtIdEliminar.Text = "";
                CargarsDataGrid();
            }
        }

        private void CargarsDataGrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = aplicacionBusiness.ObtenerAplicaciones();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
