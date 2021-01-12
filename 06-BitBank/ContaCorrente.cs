using System;

namespace _06_BitBank
{
    public class ContaCorrente
    {
        private Cliente _titular;

        public Cliente Titular
        {
            get
            {
                return this._titular;
            }
            set
            {
                if (value is null)
                {
                    Console.WriteLine("You need to set a titular");
                }

                this._titular = value;
            }
        }

        private static int TotalContasCriadas { get; set; }

        private int _agencia;

        public int Agencia
        {
            get
            {
                return this._agencia;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                this._agencia = value;
            }
        }



        public int NumeroCC { get; set; }
        // ADICIONADO VALOR INICIAL DE 100
        // ADICIONAR O _ É UMA FORMA DE SEPARAR O NOME DA PROPRIEDADE É DIFERENTE DO GETTER SETTER
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            this.Agencia = agencia;
            this.NumeroCC = numero;

            ContaCorrente.TotalContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}

