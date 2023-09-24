double ConsumoEnergia, HorasDeUso;
decimal custo, calculomês;

Console.WriteLine("----- CONSUMO DE ENERGIA-----------\n");

Console.Write("Consumo do aparelho em (kwh/mês):");
ConsumoEnergia = Convert.ToDouble(Console.ReadLine());

Console.Write("Horas de uso por dia:");
HorasDeUso = Convert.ToDouble(Console.ReadLine());

Console.Write("Custo de energia em $:");
custo = Convert.ToDecimal(Console.ReadLine());

calculomês = Convert.ToDecimal(ConsumoEnergia * HorasDeUso) * custo;

Console.WriteLine($"\nSeu custo será de: {calculomês:C}");
