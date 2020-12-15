using System;

namespace _Introducao_Abstração.classes
{
    public abstract class Pagamento
    {
        //Atributos
        private DateTime data;

        public float valor;
        
        //Métodos
        public string Cancelar(){

            return "-----    Operação Cancelada";

        }

    }
}