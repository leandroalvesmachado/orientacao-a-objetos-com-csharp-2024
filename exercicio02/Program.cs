/*
    Exercício 02
    - Crie um projeto: dotner new console -n exercicio02
    
    - Atividade: Criar uma classe Aluno, contendo os atributos:
        a) nome
        b) nota1
        c) nota2

        Haverá três métodos, sendo dois privados e um público.
        Media: Método privado para retornar a média do aluno
        Situacao: Método privado para retornar se está aprovado ou reprovado
        Mensagem: Método público para retornar o nome, média e situação
    
    - O que vamos utilizar: Class, atributo, método, objeto e encapsulamento.
*/

Aluno aluno = new();
aluno.Nome = "Ralf";
aluno.Nota1 = 7;
aluno.Nota2 = 8;

// Ralf está Aprovado com média 7.5
aluno.Mensagem(); 