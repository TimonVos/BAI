// See https://aka.ms/new-console-template for more information
Opgave1BitWise();


static void Opgave1BitWise()
{
    byte[] input = new byte[256];
    for (int i = 0; i <= 255; i++)
    {
        input[i] = (byte)i;
    }

    int[] vrouw = new int[4];
    int[] man = new int[4];
    foreach (byte b in input)
    {
        if (Convert.ToBoolean(b & (1 << 0)))
        {
            if (Convert.ToBoolean(b & (1 << 3))) // vrouw
            {
                switch (b & (0b11 << 1))
                {
                    case 0b00: // wit
                        vrouw[0] += (b & (0b1111 << 4));
                        break;
                    case 0b01: // groen
                        vrouw[1] += (b & (0b1111 << 4));
                        break;
                    case 0b10: // oranje
                        vrouw[2] += (b & (0b1111 << 4));
                        break;
                    case 0b11: // rood
                        vrouw[3] += (b & (0b1111 << 4));
                        break;
                }
            }
            else // man
            {
                switch (b & (0b11 << 1))
                {
                    case 0b00: // wit
                        man[0] += (b & (0b1111 << 4));
                        break;
                    case 0b01: // groen
                        man[1] += (b & (0b1111 << 4));
                        break;
                    case 0b10: // oranje
                        man[2] += (b & (0b1111 << 4));
                        break;
                    case 0b11: // rood
                        man[3] += (b & (0b1111 << 4));
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine($"{b}, Data is corrupted!");
        }
    }

    Console.WriteLine($"vrouw groen: {vrouw[1]}");
    Console.WriteLine($"vrouw oranje: {vrouw[2]}");
    Console.WriteLine($"man groen: {man[1]}");
    Console.WriteLine($"man oranje: {man[2]}");
}