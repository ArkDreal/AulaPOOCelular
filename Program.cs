using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular Xiaomi = new Celular();
            Xiaomi.modelo = "Redmi Note 8";
            Xiaomi.cor = "Azul Marinho";
            Xiaomi.tamanho = "15 cm de Atura e 7 cm de Largura";
            Xiaomi.ligado = false;
            string selecionar1 = "";
            int selecionar2 = 0;

            Console.WriteLine($@"
    Modelo: {Xiaomi.modelo}
    Cor: {Xiaomi.cor}
    Tamanho: {Xiaomi.tamanho} 
    
            +---------+
            |         |
            |         |
            |         |
            |         |
            |         |
            |         |
            |---------|
            |   ( )   |
            +---------+ 
    Deseja ligar o {Xiaomi.modelo}? (s/n)
            ");
            selecionar1 = Console.ReadLine().ToLower();
            if (selecionar1 == "s")
            {
                Xiaomi.Ligar();
            }
            while (Xiaomi.ligado == true)
            {

                Console.WriteLine($@"
    
            O {Xiaomi.modelo} está ligado!
            +---------------------+
            |                     |
            |   Olá               |
            |  1-Enviar SMS       |
            |  2-Fazer uma Ligação|
            |  3-Desligar         |
            |                     |
            | Selecione uma opção |
            |                     |
            |---------------------|
            |         ( )         |
            +---------------------+ 
            ");
                selecionar2 = int.Parse(Console.ReadLine());
                if (selecionar2 == 1)
                {
                    Console.WriteLine(@"Digite o contato:
Odirlei
Thiago
Paulo
Cortella
Ismot
Martins
Mãe
Pai
Beatriz
Higor
                    ");
                    string contato = Console.ReadLine();

                    Console.WriteLine("Digite a mensagem:");
                    string sms = Console.ReadLine();
                    Console.WriteLine($@"
            +---------------------+
            |                     |
            |    Para: {contato}  |
            |    Sua mensagem:    |
            |    {sms}            |
            |                     |
            |    {Xiaomi.Enviar_Mensagem()}|
            |                     |
            |                     |
            |---------------------|
            |         ( )         |
            +---------------------+ 
            ");

                }
                else if (selecionar2 == 2)
                {
                    Console.WriteLine(@"Digite o contato:
Odirlei
Thiago
Paulo
Cortella
Ismot
Martins
Mãe
Pai
Beatriz
Higor
                    ");
                    string contato = Console.ReadLine();
                    Console.WriteLine($@"
            +---------------------+
            |                     |
            |    Para: {contato}  |
            |                     |
            |    {Xiaomi.Fazer_Ligação()}|
            |                     |
            |                     |
            |                     |
            |                     |
            |---------------------|
            |         ( )         |
            +---------------------+ 
            ");
                }
                else
                {
                    Xiaomi.Desligar();
                }
            }
        }
    }
}
        
    

