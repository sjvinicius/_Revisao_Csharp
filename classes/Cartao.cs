namespace _Introducao_Abstração.classes
{
    public abstract class Cartao : Pagamento
    {
        //Atributos
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv; 

        
        //Métodos
        public string SalvarCartao(string bandeira, string numero, string titular, string cvv) {

            return $"------    Cartão Salvo\n\n-----    Titular: {this.titular} \n-----    Bandeira: {this.bandeira} \n-----    Número: {this.numero} \n-----    CVV: {this.cvv} ";

        }

        public abstract string Pagar();

    }
}