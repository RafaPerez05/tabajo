namespace EquipeEsports;

public struct Equipe{

    public string nome;
    public double campVencido;
    public double valorPremiacao;
    public double anoEstrea;

    public Equipe(string nome, double campVencido, double valorPremiacao, double anoEstrea){
        this.nome = nome;
        this.campVencido = campVencido;
        this.valorPremiacao = valorPremiacao;
        this.anoEstrea = anoEstrea;
    }

    public void RegistaCampeonatosVencidos(double nmrC){
        this.campVencido = this.campVencido + 1;
        AtualizaValorPremiacoes(1000);
    }
        public void AtualizaValorPremiacoes(double nmrP){
        this.valorPremiacao = this.valorPremiacao + nmrP;
    }

        public string verificaAnoEstrea(){
            if(this.anoEstrea < 2010){
                        return "\nA equipe estreou em:  " + this.anoEstrea + "  É veterana";

            }
            else
                        return "\nA equipe estreou em:  " + this.anoEstrea + "  É novata";
    }

    public string imprimir(){
        return "\nNome:  " + this.nome +
               "\nCampeonato Vencido:  " + this.campVencido +
               "\nValor Premiacao: " + this.valorPremiacao;
    }

}