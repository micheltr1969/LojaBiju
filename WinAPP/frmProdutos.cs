using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using BLL;
using ENTITY;

namespace WinAPP
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregaProdutos();
        }

        private void CarregaProdutos()
        {
            int? operacao = null;
            int? idProduto = null;
            string descricao = "";
            string codBarra = "";
            DateTime? data = null;
            decimal valorBRA = 0;
            decimal valorUSA = 0;
            decimal valorVendaBRA = 0;
            decimal valorVendaUSA = 0;
            int? idTipo = null;
            int? idCategoria = null;
            string modelo = "";
            int? idUsuario = null;
            int? idUsuarioAlteracao = null;
            DateTime? dataAlteracao = null;

            var retorno = BCProduto.PesquisaSP(idProduto, descricao, codBarra, idTipo, idCategoria, modelo);

            BindingSource bs = new BindingSource();
            bs.DataSource = retorno; 
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;

            dataGridView1.Columns[1].HeaderText = "DESCRIÇÃO";
            dataGridView1.Columns[0].Visible = false;
            
            descricaoTextBox.DataBindings.Add(new Binding("Text", bs, "descricao", true));


        }

     
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
