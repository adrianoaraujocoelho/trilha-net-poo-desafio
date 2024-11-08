using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("123456789", "Nokia Model X", "64GB");
        Iphone iphone = new Iphone("987654321", "iPhone Model Y", "128GB");

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}









