// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem-vindo à academia Healthy Life!");  // Mensagem de boas-vindas para o usuário
Console.WriteLine("Este teste de IMC irá indicar a condição de saúde do seu corpo, e assim poderemos te proporcionar o melhor tratamento!");

Console.WriteLine("Informe seu peso em kilos: ");     // Entrada de dados
double peso = Convert.ToDouble(Console.ReadLine());  // Lê o valor digitado e converte para número decimal (double)


Console.WriteLine("Informe sua altura em metros: ");   // Entrada de dados
double altura = Convert.ToDouble(Console.ReadLine()); // Lê o valor digitado e converte para número decimal (double)

double imc = peso / (altura * altura) * 10000;    // Cálculo do IMC, sendo multiplicado por 10000 para ser mostrado em apenas 2 casas decimais
Console.WriteLine($"O seu IMC é : {imc}");       // Mostra o IMC 

if (imc < 18.5)  // Classificação do IMC
{
    Console.WriteLine("Classificação: Abaixo do peso");
}
else if (imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine("Classificação: Peso normal");
}
else if (imc >= 25 && imc <= 29.9)
{
    Console.WriteLine("Classificação: Sobrepeso");
}
Console.WriteLine("Obrigada por ralizar o nosso teste!");  // Mensagem final de agradecimento
Console.WriteLine("Agora você sabe o condicionamento do seu corpo, e assim poderá pedir ajuda de um dos nossos profissionais para manter e/ou recuperar a saúde dele.");