using System;
namespace Excecoes.Entidades {
    internal class Reservas {
        public int NumeroQuarto { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }

        public Reservas(int numeroQuarto, DateTime entrada, DateTime saida) {
            this.NumeroQuarto = numeroQuarto;
            this.Entrada = entrada;
            this.Saida = saida;
        }
        public int Duracao() {
            // TimeSpan é usado para calcular duração de um período
            TimeSpan duracao = Saida.Subtract(Entrada);

            // Para transformar em dias usa-se a função "Total.Days"
            // transformando os dados em inteiro, pois o retorno do
            // "TotalDays" é feito em formato "Double".
            return (int)duracao.TotalDays;
        }
        public void AtualizarData(DateTime entrada, DateTime saida) {
            this.Entrada = entrada;
            this.Saida = saida;
        }

        public override string ToString() {
            return "Quarto: "
            + NumeroQuarto
            + ", Check-in: "
            + Entrada.ToString("dd/MM/yyyy")
            + ", Check-out: "
            + Saida.ToString("dd/MM/yyyy")
            + ", "
            + Duracao() //Colocar a função e não a variável.
            + " Noites.";
        }
    }
}
