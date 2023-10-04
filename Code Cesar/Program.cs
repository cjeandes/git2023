using System;

class CaesarCipher
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenue dans le chiffrement de César!");

        while (true)
        {
            Console.WriteLine("Choisissez une option:");
            Console.WriteLine("1. Chiffrer un message");
            Console.WriteLine("2. Déchiffrer un message");
            Console.WriteLine("3. Quitter");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Entrez le message à chiffrer :");
                    string plaintext = Console.ReadLine();
                    Console.WriteLine("Entrez la clé de chiffrement (0-25) :");
                    int key = int.Parse(Console.ReadLine());
                    string encryptedText = Encrypt(plaintext, key);
                    Console.WriteLine("Message chiffré : " + encryptedText);
                    break;
                case "2":
                    Console.WriteLine("Entrez le message à déchiffrer :");
                    string ciphertext = Console.ReadLine();
                    Console.WriteLine("Entrez la clé de déchiffrement (0-25) :");
                    int decryptKey = int.Parse(Console.ReadLine());
                    string decryptedText = Decrypt(ciphertext, decryptKey);
                    Console.WriteLine("Message déchiffré : " + decryptedText);
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Option invalide.");
                    break;
            }
        }
    }

    static string Encrypt(string input, int key)
    {
        string encryptedText = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char encryptedChar = (char)(((c - 'a' + key) % 26) + 'a');
                encryptedText += encryptedChar;
            }
            else
            {
                encryptedText += c;
            }
        }
        return encryptedText;
    }

    static string Decrypt(string input, int key)
    {
        string decryptedText = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char decryptedChar = (char)(((c - 'a' - key + 26) % 26) + 'a');
                decryptedText += decryptedChar;
            }
            else
            {
                decryptedText += c;
            }
        }
        return decryptedText;
    }
}
