
namespace Pratica_S13L1
{
    public class Dipendente
    {
        public string? nome;
        public string? cognome;
        public int eta;
        public string? impiego;

        public Dipendente()
        {

        }

        public Dipendente(string nome, string cognome, int eta, string impiego)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
            this.impiego = impiego;
        }
    }
}
