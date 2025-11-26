Console.Clear();

string chatbot="--- Groot Chatbot ---";
Console.WriteLine(chatbot);

string pergunta="";
int n=0;

while(pergunta!="TCHAU")
{
string groot="Eu sou Groot.";

if(n==0){
Console.Write("Digite sua pergunta ao Groot: ");

}else{
Console.WriteLine("Pergunta: ");
}

pergunta=Console.ReadLine()!;
pergunta=pergunta.ToUpper();

if(pergunta!="TCHAU"){
     Console.WriteLine($"Resposta: {groot}");

     if(n==0){ 
    Thread.Sleep(2000);
    Console.Clear();
    n=1;
    Console.WriteLine(chatbot);
}


}
else
{groot="Eu sou Groot!";
Console.WriteLine($"Resposta: {groot}");
n=1;
}

}

