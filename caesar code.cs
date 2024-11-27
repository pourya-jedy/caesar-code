using System;


namespace caesar_code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if you want to encode your messages choose sender name");
            string Sender = Console.ReadLine();
            Sender = Sender.ToLower();
            Console.WriteLine("if you want to encode your messages choose receiver name");
            string Receiver = Console.ReadLine();
            Receiver = Receiver.ToLower();
            char[] secretMessage = Sender.ToCharArray();
            Encode(secretMessage,3);
            string secret = Encode(secretMessage, 3);
            Console.WriteLine(secret);
            Console.ReadKey();


        }

        static string Encode(char[] secretMessage, int key)
        {
            char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int length = secretMessage.Length;
            //Console.Writeline(lenght);
            char[] encodedMessage = new char[length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                var letter = secretMessage[i];
                int index = Array.IndexOf(alphabet, letter);
                int newIndex = (key + index) % 26;
                char newLetter = alphabet[newIndex];
                encodedMessage[i] = newLetter;
            }
            string enMessage = String.Join("", encodedMessage);
            //Console.WriteLine(enMessage);
            return enMessage;
        }
        static string decode(char[] secretMessage, int key)
        {
            char[] alphabet = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int length = secretMessage.Length;
            // Console.WriteLine(length);
            char[] encodedMessage = new char[length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                var letter = secretMessage[i];
                int index = Array.IndexOf(alphabet, letter);
                int newIndex = (index - key) % 26;
                char newLetter = alphabet[newIndex];
                encodedMessage[i] = newLetter;
            }
            string enMessage = String.Join("",encodedMessage);
            return enMessage ;
        }
    }
    
}
