using System;

Console.WriteLine("------- BEM VINDO AO MASTER COOCKIE CLICKER SUPRA SURF BLADE DIVERS -------");
Console.WriteLine("clique 0 para almentar as coins:\r\n");
bool running = true;
int coin = 0;

while (running)
{
    Console.WriteLine($"2 : buy                       COINS: {coin}\r\n");
    int clicker = Convert.ToInt32(Console.ReadLine());
    switch (clicker)
    {
        case 0:
            coin = coin + 10;
            break;

        case 2:
            Console.WriteLine("\r\n------- MENU -------\r\n");
            Console.WriteLine("MACHINES:\r\n");
            Console.WriteLine("1 - DevOlds    $: 100     clickers: 5\r\n2 - Xlr9       $: 1000    clickers: 10\r\n3 - DevOlds    $: 1100    clickers: 15\r\n4 - Macha      $: 1250    clickers: 17\r\n5 - DevOlds    $: 1500    clickers: 20\r\n");
            int buy = Convert.ToInt32(Console.ReadLine());         
            DevOlds devOlds = new DevOlds();
            Xlr9 xlr9 = new Xlr9();
            Xsupra xsupra = new Xsupra();
            Macha macha = new Macha();
            Zom zom = new Zom();
            if (buy == 1 && coin > devOlds.Cost)
            {
                coin = coin - devOlds.Cost;
            }
            if (buy == 2 && coin > xlr9.Cost)
            {
                coin = coin - xlr9.Cost;
            }
            if (buy == 3 && coin > xsupra.Cost)
            {
                coin = coin - xsupra.Cost;
            }
            if (buy == 4 && coin > macha.Cost)
            {
                coin = coin - macha.Cost;
            }
            if (buy == 5 && coin > zom.Cost)
            {
                coin = coin - zom.Cost;
            }
            break;

        case 1:
            Console.WriteLine($"Você ficou com {coin}");
            running = false;
            break;
    }

}