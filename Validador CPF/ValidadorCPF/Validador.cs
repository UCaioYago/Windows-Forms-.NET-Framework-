using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorCPF
{
    public class Validador
    {

       public bool  CPF(string numero)
        {
            bool verificador = false;
            bool digito1 = false;
            bool digito2 = false;
            string cpf;

            //333.222.111-00
            string[] mask = numero.Split('.');
            //mask[0] = 333
            //mask[1] = 222
            //mask[2] = 111-00
            string[] dig = mask[2].Split('-');
            //dig[0] = 111
            //dig[1] = 00

            cpf = mask[0] + mask[1] + dig[0] + dig[1];

            string[] Ccpf = new string[11];             //array para armazenar os dígitos do cpf

            for (int i = 0; i < cpf.Length; i++)
            {
                Ccpf[i] = cpf.Substring(i, 1);
            }
            
            int[] multiplicadores = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 }; //array para armazenar os multiplicadores

            int[] resultado = new int[9];  //array para armazenar o resultado da multiplicação entre os arrays (ccpf e multiplicadores)

            
            for(int i = 0; i<9; i++)
            {
                resultado[i] = Convert.ToInt32(Ccpf[i]) * multiplicadores[i];
            }

            int totalTabela1 = 0;
            for(int i=0; i<9; i++)
            {
                totalTabela1 = totalTabela1 + resultado[i];
            }

            int parteInteira = totalTabela1/11;
            int restoDivisao = totalTabela1 % 11;  //retorna o Resto da divisão...

            int primeiroDigito;

            if(restoDivisao < 2)
            {
                primeiroDigito = 0;
            }
            else
            {
                primeiroDigito = 11 - restoDivisao;
            }
            //Comparação final entre o dígito calculado e o dígito inserido...
            if(Convert.ToInt32(Ccpf[9]) != primeiroDigito)
            {
                digito1 = false;
            }
            else
            {
                digito1 = true;
            }



            //Verificação para o segundo dígito do CPF:
            int[] multiplicadores2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 }; //array para armazenar os multiplicadores

            int[] resultado2 = new int[10];  //array para armazenar o resultado da multiplicação entre os arrays (ccpf e multiplicadores)

            for(int i = 0; i<10; i++)
            {
                resultado2[i] = Convert.ToInt32(Ccpf[i]) * multiplicadores2[i];
            }

            int totalTabela2 = 0;

            for(int i = 0; i<10; i++)
            {
                totalTabela2 = totalTabela2 + resultado2[i];
            }

            int parteInteira2 = totalTabela2 / 11;
            int restoDivisao2 = totalTabela2 % 11;  //retorna o Resto da divisão...

            int segundoDigito;

            if(restoDivisao2 < 2)
            {
                segundoDigito = 0;
            }
            else
            {
                segundoDigito = 11 - restoDivisao2;
            }

            if(Convert.ToInt32(Ccpf[10]) != segundoDigito)
            {
                digito2 = false;
            }
            else
            {
                digito2 = true;
            }

            //Verificação do estado dos dígitos calculados...
            if(digito1 == true && digito2 == true)
            {
                verificador = true;
            }
            else
            {
                verificador = false;
            }


            return (verificador);
        }




        public bool Telefone(string numero)
        {
            bool verificador = false;

            int posicao = numero.IndexOf('9', 5, 1);

            if(posicao == 5)  //significa qúe é um celular...
            {
                if(numero.Length == 15)
                {
                    verificador = true;
                }
                else
                {
                    verificador = false;
                }
            }
            else             //significa que é um número Fixo...
            {
                if(numero.Length == 14)
                {
                    verificador = true;
                }
                else
                {
                    verificador = false;
                }
            }

            return (verificador);
        }

        public bool Email(string endereco)
        {
            bool verificador = false;
            verificador = endereco.Contains("@") && endereco.Contains(".com");
            return (verificador);
        }
    }
}
