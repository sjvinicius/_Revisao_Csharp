namespace _Introducao_Abstração.classes
{
    public class Debito : Cartao
    {
        
        //Atributos
        private float saldo = 600;




        //Métodos
        public override string Pagar()
        {
            
            if (saldo > valor)
            {
                
                saldo = saldo - valor;
                return $"-----    OPERAÇÃO REALIZADA !!!\n-----    Saldo: R${saldo} ";

            }
            

            return $"-----    OPERAÇÃO NÃO REALIZADA !!! \n-----    Saldo: R${saldo}";

        }





    }
}