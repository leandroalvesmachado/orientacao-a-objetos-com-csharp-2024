// Interface é como uma classe base abstrata que contém apenas 
// métodos abstratos (métodos obrigatórios) que as classes que herdam precisam implementar
interface ICalculadoraBase
{
    double Soma();
    double Subtracao();
    double Multiplicacao();
    double Divisao();
}