using byteBank.Titular;

namespace byteBank
{
    public class contaCorrente
    {
        
        public Cliente Titular { get; set; }
        public string Nome_agencia { get; set; }

        private int _numero_agencia;
        public int Numero_agencia 
        { 
            get
            {
                return _numero_agencia;
            }
            set
            {
                if(value <= 0 )
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            } 
        }

        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        private double saldo;
        public double Saldo
        {
            get { return saldo; }   
            set
            {
                if(value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }
    public double Sacar (double valor)
    {
       if (saldo < valor || valor < 0 )
        {
            return saldo;
        }    
       else
        {
            saldo = saldo - valor;
            return saldo;
        }
    } 

    public void Depositar (double valor)
        {
            saldo = saldo + valor;
        }
    public bool Transferir (double valor , contaCorrente destino)
    {
        if (saldo < valor || valor < 0)
        {
            return false;
        }
        else
        {
            saldo = saldo - valor;
            destino.saldo = destino.saldo + valor;
            return true;
        }
    }

    
    public contaCorrente (int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

    public static int TotalDeContasCriadas { get; set; }
    }


}