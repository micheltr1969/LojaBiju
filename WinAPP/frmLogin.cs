using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace WinAPP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? idUsuario = null;
            string nome = "";
            string login = textBoxLogin.Text;
            string senha = textBoxSenha.Text;
            int? idStatus = null;
            const string message = "Login ou senha Inválido!";
            const string caption = "Aviso";


            if (login != "" && senha != "")
            {
                idStatus = 1;
                var retorno = BCUsuario.PesquisaSP(idUsuario, nome, login, senha, idStatus);
                
                
                if (retorno.Count.Equals(0))
                {
                    var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Warning);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Warning);
            }
                        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
