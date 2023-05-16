namespace JogadorFutebol;

public struct Jogador{

    public string nome;
    public double cv;
    public double ca;
    public string clube;

    public Jogador(string nome, double cv, double ca, string clube){
        this.nome = nome;
        this.cv = cv;
        this.ca = ca;
        this.clube = clube;
    }

    public void aumentaCA(double nmrC){
        this.ca = this.ca + nmrC;
    }

        public void aumentaCV(double nmrC){
        this.cv = this.cv + nmrC;
    }

        public string verificaClube(){
        return "\nJogador é contratado pelo:  " + this.clube;
    }

    public string imprimir(){
        return "\nNome:  " + this.nome +
               "\nCartões Vermelhos:  " + this.cv +
               "\nCartões Amarelos: " + this.ca;

    }

}