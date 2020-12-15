namespace _Introducao_Abstração.classes
{
    public class Credito : Cartao
    {
        //Atributos
        private float limite = 3000;
        public float Limite { 

            get { return limite;}
            
        }

        protected int parc;
        public int Parc {

            get { return parc; }
            set { value = parc; }

        }
        
        
        //Métodos
        public override string Pagar()
        {

                if (this.parc < 6 && this.parc >= 0) 
                {                  
                    
                    if ( this.limite < valor )
                    {
                        
                        return $"-----    Saldo Insuficiente \n-----    Saldo: {limite} \n-----    Valor: {valor} \n OPERAÇÃO NÃO EFETUADA";

                    }else

                    {
                        
                    limite = limite - valor;

                    return $" Limite Atual: {limite} \n OPERAÇÃO EFETUADA !!!";
                    
                    }

                }
                else if (this.parc > 0 && this.parc >= 6)
                {

                    float juros;

                    juros = valor / 100 * 6;
                    valor = valor + juros;


                    if ( this.limite < valor )
                    {
                        
                        return $"-----    Saldo Insuficiente \n-----    Saldo: {limite} \n-----    Valor: {valor} \n-----   OPERAÇÃO NÃO EFETUADA";

                    }else

                    {
                        
                    limite = limite - valor;

                    return $"-----  Limite Atual: {limite} \n-----    OPERAÇÃO EFETUADA !!!";
                    
                    }


                }          

            return ""; 
            
        }
    }
}