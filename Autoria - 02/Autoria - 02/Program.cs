// See https://aka.ms/new-console-template for more information
Console.WriteLine("=== Quiz de Personalidade ===");  //Introdução ao Quiz
Console.WriteLine("Responda às perguntas digitando a opção (A ou B).");  //Formas de respoder o Quiz

int pontosA = 0;
int pontosB = 0;

// Pergunta 1
Console.WriteLine("\n1) Você prefere:");
Console.WriteLine("A) Ficar em casa assistindo séries.");
Console.WriteLine("B) Sair com os amigos(as).");
Console.Write("Sua escolha: ");
string resposta = Console.ReadLine().ToUpper();

if (resposta == "A") pontosA++;
else if (resposta == "B") pontosB++;

// Pergunta 2
Console.WriteLine("\n2) Você gosta mais de:");
Console.WriteLine("A) Ler um bom livro. ");
Console.WriteLine("B) Ver TikTok ou Instagram. ");
Console.Write("Sua escolha: ");
resposta = Console.ReadLine().ToUpper();

if (resposta == "A") pontosA++;
else if (resposta == "B") pontosB++;

// Pergunta 3
Console.WriteLine("\n3) Você se considera mais:");
Console.WriteLine("A) Calmo(a) e tranquilo(a). ");
Console.WriteLine("B) Energético(a) e agitado(a). ");
Console.Write("Sua escolha: ");
resposta = Console.ReadLine().ToUpper();

if (resposta == "A") pontosA++;
else if (resposta == "B") pontosB++;

// Pergunta 4
Console.WriteLine("\n4) Você prefere:");
Console.WriteLine("A) Planejar tudo com antecedência. ");
Console.WriteLine("B) Deixar para a data limite. ");
Console.Write("Sua escolha: ");
resposta = Console.ReadLine().ToUpper();

if (resposta == "A") pontosA++;
else if (resposta == "B") pontosB++;

//Pergunta 5
Console.WriteLine("\n4) Você prefere:");
Console.WriteLine("A) Escutar POP e/ou KPOP.");
Console.WriteLine("B) Escutar ROCK. ");
Console.Write("Sua escolha: ");
resposta = Console.ReadLine().ToUpper();

if (resposta == "A") pontosA++;
else if (resposta == "B") pontosB++;


// Resultado final
Console.WriteLine("\n=== Resultado do Quiz ===");

if (pontosA > pontosB)
{
    Console.WriteLine("Você é uma pessoa mais tranquila, organizada, caseira e gosta de divas POP e/ou grupos de KPOP!"); //Personalidade se o número de alternativas marcadas como A > B
}
else if (pontosB > pontosA)
{
    Console.WriteLine("Você é uma pessoa extrovertida, animada, cheia de energia e curte estilos musicais alternativos!"); //Personalidade se o número de alternativas marcadas como B > A
}
else
{
    Console.WriteLine("Você tem um equilíbrio entre tranquilidade, energia e curte estilos diversificados!"); //Personalidade se o número de alternativas marcadas for proporcinal entre A e B
}

Console.WriteLine("\nObrigado(a) por jogar o Quiz de Personalidade!"); //Mensagem de despedida 
    
