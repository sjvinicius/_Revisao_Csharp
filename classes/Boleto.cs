namespace _Introducao_Abstração.classes
{
    public class Boleto : Pagamento
    {
        //Atributos
        private string codigoDeBarras;

        //Métodos
        public string Registrar(string numbolet, char r) {

             if (numbolet == "" && numbolet.Length <= 47 )
             {
                 
                 numbolet = codigoDeBarras;

                 return "Operação efetuada";

             } else
             {
                 
                r = 's';
                return " O número digitado não corresponde ao código de barras do boleto ";
             }

        }

    }
}