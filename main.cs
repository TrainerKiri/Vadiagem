using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cadastroClienteApp
{
    public partial class MainForms : forms
    public MainForm()
    {
        initializeComponent();
    }
}

private void btnSalvar_Click(objetcs sender, EventArgs e) 
{
    SalvarDados Cliente(txtNome.Text, txtEndereco.Text, txtTelefone.Text,txtEmail.Text);
}
