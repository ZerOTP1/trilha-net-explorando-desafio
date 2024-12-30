namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            bool capacidadeMaiorOuIgual = Suite.Capacidade >= hospedes.Count;
            
            if (capacidadeMaiorOuIgual)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade insuficiente para a quantidade de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            return  Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            var valorSuite = Suite.ValorDiaria;
            decimal valor = DiasReservados * valorSuite;


            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.1m);
            }

            return valor;
        }
    }
}