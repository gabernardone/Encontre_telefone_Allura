using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Allura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string PesquisaDicionario(string valor)
        {




            return valor;
        }
        public String Limpa(string telefone)
        {
            telefone = telefone.Replace("-", "");

            //Declarando o objeto Dictionary, e o tipo
            //para a chave e para o valor.
            Dictionary<int, string> dicTelefone = new Dictionary<int, string>();

            //Preenchendo o dicionario de dados
            //dicTelefone.Add(key, value);

            dicTelefone.Add(2, "ABC");

            dicTelefone.Add(3, "DEF");

            dicTelefone.Add(4, "GHI");

            dicTelefone.Add(5, "JKL");

            dicTelefone.Add(6, "MNO");

            dicTelefone.Add(7, "PQRS");

            dicTelefone.Add(8, "TUV");

            dicTelefone.Add(9, "WXYZ");

            string result = string.Empty;

            for (int i = 0; i < telefone.Length; i++)
            {

                //Regex que vc quer
                string verifica = "^[a-zA-Z]";
                string Caracter = telefone[i].ToString();

                if (Regex.IsMatch(Caracter, verifica))
                {
                    if (dicTelefone[1].Contains(telefone[i]))
                    {
                        switch (telefone[i])
                        {
                            case 'A':
                            case 'B':
                            case 'C':

                                var pesquisar = dicTelefone.Where(p => p.Key == telefone[i]).Select(p => p.Value);

                                foreach (var key in pesquisar)
                                {
                                    result += key.ToString();
                                }

                                break;
                        }

                    }
                }
                
            }
            return string.Join("", result);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTelefoneLimpo.Text = Limpa(txtTelefone.Text);
        }
    }
}
