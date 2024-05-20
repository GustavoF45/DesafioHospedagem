using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(int diasReservados)
    {
        Hospedes = new List<Pessoa>();
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
        if (hospedes.Count > Suite.Capacidade)
        {
            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes
            throw new Exception("Número de hóspedes excede a capacidade da suíte.");
        }
        Hospedes = hospedes;
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        // TODO: Retornar o valor da diária 
        // Calculo: DiasReservados * Suite.ValorDiaria
        decimal valor = DiasReservados * Suite.ValorDiaria;
        if (DiasReservados >= 10)
        {
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            valor *= 0.9m;
        }
        return valor;
    }
}
}