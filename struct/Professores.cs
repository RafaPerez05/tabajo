namespace Professores;

public struct Professor{

    public string nome;
    public double salario;
    public double faltas;
    public double cargaH;

    public Professor(string nome, double salario, double faltas, double cargaH){
        this.nome = nome;
        this.salario = salario;
        this.faltas = faltas;
        this.cargaH = cargaH;
    }



    public string reajusteSalarialEmValor(double ajuste){
        this.salario = this.salario + ajuste;
        return "\nFoi aplicado um Reajuste Salarial no valor de" + ajuste + " novo salario é: "+ this.salario;
    }
    
    public string reajusteSalarialEmPorcentagem(double porcentagem){
        this.salario = this.salario / porcentagem + this.salario;
        return "\nFoi aplicado um Reajuste Salarial no valor de " + porcentagem + "% , novo salario é:  " + this.salario;
    }

    public string descontoSalarialPorFaltaEmValor(){
        this.salario = this.salario - this.faltas * 10;
        return "\nPor ocorrencia de faltas foi aplicado um Reajuste Salarial no valor de " + this.faltas * 10 + ", novo salario é:  " + this.salario;
    }

        public string descontoSalarialPorFaltaEmPorcentagem(double porcentagem){
        porcentagem = porcentagem + this.faltas * 10;
        this.salario = this.salario / porcentagem + this.salario;
        return "\nPor ocorrencia de faltas foi aplicado um Reajuste Salarial no valor de " + porcentagem + "% , novo salario é:  " + this.salario;
    }

        public string aumentarCargaHorariaDeTrabalho(double qtd){
            qtd = qtd * 50;
            this.salario = this.salario + qtd;
            return "\nCom o aumento de carga horaria houve um aumento no salario de " + qtd + ", novo salario é:  " + this.salario;
    }


    public string imprimir(){
        return "\nNome:  " + this.nome +
               "\nSalario:  " + this.salario +
               "\nFaltas:  " + this.faltas +
               "\nCarga Horaria:  " + this.cargaH;

    }

}