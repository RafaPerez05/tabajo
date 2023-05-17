namespace Produtos;

public struct Produto{

    public string nome;
    public double qtd;
    public double desconto;
    public double valor;

    public Produto(string nome, double qtd, double desconto, double valor){
        this.nome = nome;
        this.qtd = qtd;
        this.desconto = desconto;
        this.valor = valor;
    }



    public string aplicarCupomDescontoValor(){
        this.valor = this.valor / desconto + this.valor;
        return "\nFoi aplicado um Cupom no valor de "+ this.desconto + "% , novo valor:  " + this.valor;
    }
        public string verificarQuantidadeEmEstoque(){
        return "\nO estoque atual é:  " + this.qtd;
    }

    public string imprimir(){
        return "\nNome:  " + this.nome +
               "\nValor:  " + this.valor;

    }

}