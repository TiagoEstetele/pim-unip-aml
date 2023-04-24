using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu.Forms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDataNascimento.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtDataNascimento_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtDataNascimento.SelectAll();
            }
            catch { }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtCPF.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtCPF_Click(object sender, EventArgs e)
        {
            try
            {
                txtCPF.SelectAll();
            }
            catch { }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtNome.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.SelectAll();
            }
            catch { }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmail.SelectAll();
            }
            catch { }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtTelefone_Click(object sender, EventArgs e)
        {
            try
            {
                txtTelefone.SelectAll();
            }
            catch { }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtTelefone.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtEndereco_Click(object sender, EventArgs e)
        {
            try
            {
                txtTelefone.SelectAll();

            }
            catch { }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtEndereco.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSalario.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtSalario_Click(object sender, EventArgs e)
        {
            try
            {
                txtSalario.SelectAll();

            }
            catch { }
        }

        private void txtBanco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBanco.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtBanco_Click(object sender, EventArgs e)
        {
            try
            {
                txtBanco.SelectAll();

            }
            catch { }
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtConta.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtConta_Click(object sender, EventArgs e)
        {
            try
            {
                txtConta.SelectAll();

            }
            catch { }
        }

        private void txtCTPS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtCTPS.ForeColor = System.Drawing.ColorTranslator.FromHtml("#232336");

            }
            catch { }
        }

        private void txtCTPS_Click(object sender, EventArgs e)
        {
            try
            {
                txtCTPS.SelectAll();

            }
            catch { }
        }
    }
}
