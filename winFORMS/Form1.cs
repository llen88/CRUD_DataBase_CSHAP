using System.Numerics;
using MySql.Data.MySqlClient;

using Org.BouncyCastle.Asn1.Cmp;

using System.Web;
using Mysqlx.Sql;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using MySqlX.XDevAPI;

namespace WinFormsApp5

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            //Código do cliente; Nome completo do cliente, CPF do cliente, RG do clientes, UF de nascimento(estado), Data de nascimento, celular, Sexo(M ou F).Usem os controles no C# que facilitem a vida do usuário (Caixas de texto, ComboBox, MaskedText, entre outros), mas prestem atenção na hora de gravar. Podem usar botões com imagens e o que mais facilitar a interface do usuário.

            //Conecte esse banco ao C# e crie um INSERT para cadastrar esses usuários.
            //VERIFIiquem se o cadastro está sendo feito corretamente no MySQL, consultem com um SELECT no WorkBench

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;

            MySqlCommand comando = new MySqlCommand();

            string MySql, sexo, estado;
            estado = cbbEstados.SelectedItem as string;

            if (rdbFeminino.Checked)
            {
                sexo = "F";

            }
            else
            {
                sexo = "M";

            }

            //(idCliente, nome_completo, data_nascimento, sexo,   cpf ,       rg,          estado, tel_celular )
            MySql = "DELETE FROM tb_clientes WHERE idCliente = " + "'" + txtIdCliente.Text + "'";
            //SQL = "INSERT INTO tb_aluno    (nm_nome, cd_Senha)                                                              VALUES('" + txtNome.Text       + "', '" + txtSenha.Text + "')";
            //"', '" ++"', '"
            MessageBox.Show(MySql);


            MySqlConnection conexao = new MySqlConnection("Server= localhost; Database= CADASTRO_DE_CLIENTES; User ID= root; Password =;");
            conexao.Open();


            comando.Connection = conexao;

            comando.CommandText = MySql;

            RowAffect = comando.ExecuteNonQuery();

            if (RowAffect == 1)
            {
                MessageBox.Show("Registro excluído com sucesso!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdCliente.Text = "";
                txtNomeCompleto.Text = "";
                mskNasc.Clear();
                rdbFeminino.Checked = false;
                rdbMasculino.Checked = false;
                mskCPF.Clear();
                mskTelCelular.Clear();

            }
            else
            {
                MessageBox.Show("Exclusão não realizada!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            int RowAffect = 0;

            MySqlCommand comando = new MySqlCommand();

            string MySql, sexo, estado;
            estado = cbbEstados.SelectedItem as string;

            if (rdbFeminino.Checked)
            {
                sexo = "F";

            }
            else
            {
                sexo = "M";

            }

            //(idCliente, nome_completo, data_nascimento, sexo,   cpf ,       rg,          estado, tel_celular )
            MySql = "INSERT INTO tb_clientes (idCliente, nome_completo, data_nascimento, sexo, cpf, rg, estado, tel_celular ) VALUES ('" + txtIdCliente.Text + "', '" + txtNomeCompleto.Text + "', '" + mskNasc.Text + "', '" + sexo + "', '" + mskCPF.Text + "', '" + mskRG.Text + "', '" + cbbEstados.Text + "','" + mskTelCelular.Text + "' )";    //SQL = "INSERT INTO tb_aluno    (nm_nome, cd_Senha)                                                              VALUES('" + txtNome.Text       + "', '" + txtSenha.Text + "')";
            //"', '" ++"', '"
            MessageBox.Show(MySql);


            MySqlConnection conexao = new MySqlConnection("Server= localhost; Database= CADASTRO_DE_CLIENTES; User ID= root; Password =;");
            conexao.Open();


            comando.Connection = conexao;

            comando.CommandText = MySql;

            RowAffect = comando.ExecuteNonQuery();

            if (RowAffect == 1)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdCliente.Text = "";
                txtNomeCompleto.Text = "";
                mskNasc.Clear();
                rdbFeminino.Checked = false;
                rdbMasculino.Checked = false;
                mskCPF.Clear();
                mskTelCelular.Clear();

            }
            else
            {
                MessageBox.Show("Cadastro não realizado!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();

        }

        private void mskNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            string Sql;
            string nome = "", cpf = "", nascimento = "", sexo = "", rg = "", telefone = "", estado = "";
            int id;


            MySqlConnection conexao = new MySqlConnection("Server= localhost; Database= CADASTRO_DE_CLIENTES; User ID= root; Password =;");


            MySqlCommand comando = new MySqlCommand();
            MySqlDataReader dr;




            Sql = "SELECT  * FROM tb_clientes WHERE cpf = " + "'" + mskCPF.Text + "'" + ";";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = Sql;
            dr = comando.ExecuteReader();
            while (dr.Read())
            {


                nome = dr.GetString(1);
                nascimento = dr.GetString(2);
                sexo = dr.GetString(3);
                cpf = dr.GetString(4);
                rg = dr.GetString(5);
                estado = dr.GetString(6);
                telefone = dr.GetString(7);



            };

            if (cpf.ToString() == "")
            {
                MessageBox.Show("Não existe esse registro no banco de dados!", "Aviso", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

            }
            else
            {
                if (sexo == "M")
                {


                    txtNomeCompleto.Text = nome;
                    mskNasc.Text = nascimento;
                    rdbMasculino.Checked = true;
                    mskCPF.Text = cpf;
                    mskRG.Text = rg;
                    cbbEstados.Text = estado;
                    mskTelCelular.Text = telefone;
                }

                else
                {
                    txtNomeCompleto.Text = nome;
                    mskNasc.Text = nascimento;
                    rdbFeminino.Checked = true;
                    mskCPF.Text = cpf;
                    mskRG.Text = rg;
                    cbbEstados.Text = estado;
                    mskTelCelular.Text = telefone;
                }

            }


            //conexao.Close();
        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;


        }

        private void btnAtualizar(object sender, EventArgs e)
        {
            int RowAffect = 0;


            string Sql;
            

                Sql = "UPDATE tb_clientes SET nome_completo = '" + txtNomeCompleto.Text + "', data_nascimento ='" + mskNasc.Text + "', rg ='" + mskRG.Text + "', Tel_celular ='" + mskTelCelular.Text + "', estado ='" + cbbEstados.Text + "' WHERE cpf= " + "'" + mskCPF.Text + "'" + ";";                  

            MessageBox.Show(Sql);

           

            MySqlConnection conexao = new MySqlConnection("Server= localhost; Database= CADASTRO_DE_CLIENTES; User ID= root; Password =;");
            MySqlCommand comando = new MySqlCommand();
            conexao.Open();




            comando.Connection = conexao;

            comando.CommandText = Sql;

            RowAffect = comando.ExecuteNonQuery();

            if (RowAffect == 1)
            {
                MessageBox.Show("Cadastro Atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            else
            {
                MessageBox.Show("Cadastro não Atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.Close();
        }
    }
}
