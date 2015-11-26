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
using System.Globalization;

namespace Allura
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
  
       
        public String Limpa(string telefone)
        {
            telefone = telefone.Replace("-", "");

            //Declarando o objeto Dictionary, e o tipo
            //para a chave e valor.

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

                //Regex para validar letra
                const string verifica = "^[a-zA-Z]";
                string Caracter = telefone[i].ToString();

                if (Regex.IsMatch(Caracter, verifica))
                {
                    if (dicTelefone.Any(kvp => kvp.Value.Contains(telefone[i].ToString())))
                    {

                        var resultKey = dicTelefone
                            .FirstOrDefault(x => x.Value.Contains(telefone[i].ToString()))
                            .Key;

                        telefone = telefone.Replace(Caracter, resultKey.ToString());
              
                    }
                    result = telefone;
                }

            }
            return result;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTelefoneLimpo.Text = Limpa(txtTelefone.Text);
        }
    }
}
