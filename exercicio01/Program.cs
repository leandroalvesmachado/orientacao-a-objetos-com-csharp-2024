/*
    Exercício 01

    - Crie um projeto: dotnet new console -n exercicio01
    - Atividade: Criar uma classe Produto, contendo os atributos:
        a) nome
        b) valor
        c) forma de pagamento (Á vista ou prazo)

        Haverá um método público para retornar essas três características,
        além de um possível desconto. Haverá desconto de 10% se o valor da venda
        for de pelo menos R$ 500,00 e a forma de pagamento à vista.
    - O que vamos utilizar: Classe, atributo, método, objeto e encapsulamento
*/

Produto p = new();
p.Nome = "Produto 1";
p.Valor = 600;
p.FormaPagamento = "Á vista";
p.Mensagem();