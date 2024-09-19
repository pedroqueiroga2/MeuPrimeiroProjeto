bool valida = true;
Random rand = new Random(); 
int jogo = 0;
while(valida == true)
{
Console.WriteLine("1 - Pedra\n2 - Tesoura\n3 - Papel");
int.TryParse(Console.ReadLine(), out int numero);
jogo = rand.Next(1, 3);


if(numero == 1 && jogo==3 )
{
    Console.WriteLine($"você jogou Pedra e a máquinha Papel, você perdeu");
}
else if(numero == 1 && jogo == 2 )
{
    Console.WriteLine($"você jogou Pedra e a máquinha Tesoura, você ganhou");
    valida = false;
}



if(numero == 2 && jogo==1 )
{
    Console.WriteLine($"você jogou Tesoura e a máquinha Pedra, você perdeu");
}
else if(numero == 2 && jogo == 3 )
{
    Console.WriteLine($"você jogou Tesoura e a máquinha Papel, você ganhou");
    valida = false;
}


if(numero == 3 && jogo==1 )
{
    Console.WriteLine($"você jogou Papel e a máquinha Pedra, você ganhou");
    valida = false;
}
else if(numero == 3 && jogo == 2 )
{
    Console.WriteLine($"você jogou Papel e a máquinha Tesoura, você perdeu");
}
else if(numero==jogo)
{
     Console.WriteLine($"você e a maquina jogaram a mesma coisa, empate") 
}
}

