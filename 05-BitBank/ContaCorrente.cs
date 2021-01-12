namespace _05_BitBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numeroCC;
        // ADICIONADO VALOR INICIAL DE 100
        private double saldo = 100;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }

            this.saldo = saldo;

        }

        public double ObterSaldo()
        {
            return saldo;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

