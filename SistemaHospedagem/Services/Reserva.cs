using SistemaHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagem.Services
{
    public class Reserva
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
            if (Suite.Capacidade < hospedes.Count)
            {
                throw new Exception("Ultrapassou a quantidade máxima de hospedes para essa suíte.");
            }
            else
            {
                Hospedes = hospedes;
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

        public decimal CalcularValorDiario()
        {
            if (DiasReservados >= 10)
            {
                return Suite.ValorDiaria * DiasReservados * 90 / 100;
            }
            return Suite.ValorDiaria * DiasReservados;
        }
    }
}
