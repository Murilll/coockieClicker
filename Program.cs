using System;

DevOlds devOlds = new DevOlds();
Xlr9 xlr9 = new Xlr9();
Xsupra xsupra = new Xsupra();
Macha macha = new Macha();
Zom zom = new Zom();

List<Machine> listMachine = new List<Machine>();
listMachine.Add(devOlds);
listMachine.Add(xlr9);
listMachine.Add(xsupra);
listMachine.Add(macha);
listMachine.Add(zom);


Console.WriteLine("------- BEM VINDO AO MASTER COOCKIE CLICKER SUPRA SURF BLADE DIVERS -------");
bool running = true;
int coin = 0;
int dps = 1;
while (running)
{
    
    Console.WriteLine($"2 : buy            1 : Close           COINS: {coin}\r\n");
    char a = Console.ReadKey(true).KeyChar;
    int clicker = int.Parse(a.ToString());
    switch (clicker)
    {
        case 0:
            coin = coin + dps;
            break;

        case 2:
            
            Console.WriteLine("\r\n------- MENU -------\r\n");
            Console.WriteLine("MACHINES:\r\n");        
            for (int i = 0; i < listMachine.Count; i++)
                Console.WriteLine($"{i+1} - {listMachine[i].Name}    $: {listMachine[i].Cost}      clickers: {listMachine[i].Coins} ");
            Console.WriteLine($"\nYOUR CLICKERS: {dps}       YOUR COINS: {coin}");
            int buy = Convert.ToInt32(Console.ReadLine());                               
            if (coin >= listMachine[buy-1].Cost)
            {
                coin = coin - listMachine[buy-1].Cost;
                dps += listMachine[buy-1].Coins;
                listMachine[buy-1].Time++;                
            }

            else
                Console.WriteLine("Você não tem coins suficiente! \r\n");
            break;

        case 1:
            Console.WriteLine($"Você ficou com {coin}");
            running = false;
            break;
    }

}