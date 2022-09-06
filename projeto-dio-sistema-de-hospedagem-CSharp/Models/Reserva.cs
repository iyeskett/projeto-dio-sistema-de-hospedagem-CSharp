using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_dio_sistema_de_hospedagem_CSharp.Models
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes não pode ser maior que a capacidade da suíte");
            }
        }
        
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValor()
        {
            decimal total = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados >= 10)
            {
                decimal desconto = 0.10M * total;
                return total - desconto;
            }
            return total;
        }
    }
}
