namespace SistemaDeHospedagem;
using SistemaDeHospedagem.Models;

public partial class Form1 : Form
{
    Suite suite;
    List<Pessoa> hospedes = new List<Pessoa>();
    Reserva reserva;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCadastrarSuite_Click(object sender, EventArgs e)
    {
        string tipoSuite = txtTipoSuite.Text;
        int capacidade = 0;
        if (!int.TryParse(txtCapacidade.Text, out capacidade) && capacidade <= 0)
        {
            MessageBox.Show("Valor da capacidade inválido");
        }
        decimal valor = 0;
        if (!decimal.TryParse(txtValorDiaria.Text, out valor) && valor <= 0)
        {
            MessageBox.Show("Valor da diaria inválido");
        }

        if (capacidade > 0 && valor > 0)
        {
            suite = new Suite(tipoSuite, capacidade, valor);
            MessageBox.Show("Suíte cadastrada.");
            txtTipoSuite.Enabled = false;
            txtCapacidade.Enabled = false;
            txtValorDiaria.Enabled = false;
            btnCadastrarSuite.Enabled = false;
        }
        else
        {
            MessageBox.Show("Não foi possível cadastrar, tente novamente");
        }
    }

    private void btnCadastrarPessoa_Click(object sender, EventArgs e)
    {
        if (txtNome.Text != "" && txtSobrenome.Text != "")
        {
            Pessoa pessoa = new Pessoa(txtNome.Text, txtSobrenome.Text);
            hospedes.Add(pessoa);
            MessageBox.Show("Hóspede adicionado com sucesso");
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtNome.Focus();
        }
        else
        {
            MessageBox.Show("Hóspede não adicionado, tente novamente");
        }
    }

    private void btnReservar_Click(object sender, EventArgs e)
    {
        int dias = 0;
        if (int.TryParse(txtDiasReservados.Text, out dias))
        {
            reserva = new Reserva(dias);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);
            MessageBox.Show("Reserva efetuada com sucesso.");
            txtNome.Enabled = false;
            txtSobrenome.Enabled = false;
            txtDiasReservados.Enabled = false;
            btnReservar.Enabled = false;
            btnCadastrarPessoa.Enabled = false;
        }

    }

    private void btnQuantidadeHospedes_Click(object sender, EventArgs e)
    {
        txtQuantidadeHospedes.Text = reserva.ObterQuantidadeHospedes().ToString();
    }

    private void btnValor_Click(object sender, EventArgs e)
    {
        txtValor.Text = reserva.CalcularValor().ToString();
    }
}