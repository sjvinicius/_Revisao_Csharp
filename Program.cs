using System;
using _Introducao_Abstração.classes;

namespace _Introducao_Abstração
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variáveis
            char r = 'n';
            char formpay;
            char validata = 'n';
            string numbolet;
            string cartaodebecred;
            

            //Instâncias
            Boleto boleto = new Boleto();
            Credito cartaoc = new Credito();
            Debito cartaod = new Debito();


            Console.WriteLine("-----    --------------------------------");
            Console.WriteLine("|-----    PAGAMENTO                      |");
            Console.WriteLine("|-----    -----------------              |");
            Console.WriteLine("|-----    Selecione a forma de pagamento |");
            Console.WriteLine("|-----    [1] Boleto                     |");
            Console.WriteLine("|-----    [2] Cartão                     |");
            Console.WriteLine("-----    --------------------------------");
            formpay = char.Parse( Console.ReadLine() );

            do {

                switch (formpay)
                {
                    case '1':
                        
                        do {

                            Console.WriteLine("Digite o Nº do Boleto");
                            numbolet = Console.ReadLine();

                            Console.WriteLine("Insira o valor do boleto");
                            boleto.valor = float.Parse( Console.ReadLine() );                           

                            } while (r == 's');

                        break;

                    case '2':
                            //Cartao

                            do
                            {

                                if (validata == 's') {

                                Console.WriteLine(" -----    ----------------------------------------- ");
                                Console.WriteLine("|-----    As informações inseridas não são validas |");
                                Console.WriteLine("|-----    Por favor, tente novamente.              |");
                                Console.WriteLine(" -----    ----------------------------------------- \n");

                                }
                                
                                Console.WriteLine(" -----    ------------------------------- ");
                                Console.WriteLine("|-----    Cadastrar Cartão               |");
                                Console.WriteLine(" -----    ------------------------------- ");
                                Console.Write("|-----    Bandeira:                      |");
                                cartaoc.bandeira = Console.ReadLine ();
                                Console.Write("|-----    Numero:                        |");
                                cartaoc.numero = Console.ReadLine ();
                                Console.Write("|-----    Titular:                       |");
                                cartaoc.titular = Console.ReadLine ();
                                Console.Write("|-----    CVV:                           |");
                                cartaoc.cvv = Console.ReadLine ();
                                Console.WriteLine(" -----    ------------------------------- ");


                                Console.WriteLine("|-----    Este cartão tambem possui a função débito ?");
                                cartaodebecred = Console.ReadLine().ToUpper();

                                if (cartaodebecred == "S" || cartaodebecred == "SIM" || cartaodebecred == "SI")
                                {
                                    
                                cartaod.bandeira = cartaoc.bandeira;
                                cartaod.numero = cartaoc.numero;
                                cartaod.titular = cartaoc.titular;
                                cartaod.cvv = cartaoc.cvv;
                        
                                }

                                validata = 's';

                            } while (cartaoc.bandeira == "" && cartaoc.numero.Length <= 12 && cartaoc.titular == "" && cartaoc.cvv.Length <= 2);

                            cartaoc.SalvarCartao(cartaoc.bandeira, cartaoc.numero, cartaoc.titular, cartaoc.cvv);


                            Console.WriteLine(" -----   --------------------------------------------");
                            Console.WriteLine("|-----    Selecione a forma de pagamentono  no Cartão |");
                            Console.WriteLine("|-----    [3] Crédito                                 |");
                            Console.WriteLine("|-----    [4] Débito                                  |");
                            Console.WriteLine(" -----   --------------------------------------------");
                            formpay = char.Parse( Console.ReadLine() );

                            switch (formpay)
                            {
                                case '3':

                                    Console.WriteLine(" -----   --------------------------------------------");
                                    Console.WriteLine(" -----   CRÉDITO SELECIONADO");
                                    Console.WriteLine(" -----   --------------------------------------------");
                                    Console.WriteLine(" -----   Quantas Parcelas?");
                                    cartaoc.Parc = int.Parse( Console.ReadLine() );
                                    Console.Write(" -----   Valor: ");
                                    cartaoc.valor = float.Parse( Console.ReadLine() );

                                    cartaoc.Pagar();

                                    break;

                                case '4':

                                    Console.WriteLine(" -----   --------------------------------------------");
                                    Console.WriteLine(" -----   DÉBITO SELECIONADO");
                                    Console.WriteLine(" -----   --------------------------------------------");
                                    cartaod.Pagar();
                                    

                                break;

                                default:
                                    break;
                            }
                            

                        break;

                    default: 
                    
                    Console.WriteLine ("-----    Opção inválida"); 
                    Console.WriteLine ("-----    Insira um valor válido"); 
                    Console.WriteLine(" -----   --------------------------------------------");
                    r = char.Parse("s");
                    
                    break;
                }

            }while (r == 's');
        }
    }
}
