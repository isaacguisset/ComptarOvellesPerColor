public class Program
{
    public static void Main()
    {
        string[] Ovelles = new string[]
        {
                //primer gir del cotxe 
                "blanca",//parella1    
                    "negra",//parella2
                      "blanca",//parella3
                           "blanca",//parella4

                //segon  gir del cotxe
                            "negra",//parella4
                      "blanca",//parella3
                 "negra",//parella2
            "negra",
                        "negra"//parella1 //7
//parella1 //7
                
        };
        ComptarOvellesPerColor(Ovelles);
    }
    public static void ComptarOvellesPerColor(string[] Ovelles)
    {
        int Negres = 0;
        int Blanques = 0;
        int Blanc_i_Negre = 0;
        if (Ovelles.Length % 2 != 0)
        {
            Console.WriteLine("La longitud de la llista ha de ser un número parell!");
            return;
        }
        int meitat = Ovelles.Length / 2;
        for (int i = 0; i < meitat; i++)//també podem posar directament Ovelles.Length/2
        {
            var actual = Ovelles[i];
            var seguent = Ovelles[Ovelles.Length- 1-i]; 

            Console.WriteLine($"Actual = {actual} seguent={seguent}");
            if (actual == seguent)
            {
                if (actual == "blanca")
                {
                    Blanques++;
                }
                else if (actual == "negra")
                {
                    Negres++;
                }
            }
            else
            {
                Blanc_i_Negre++;
            }
        }
        Console.WriteLine($"Hi ha {Blanques} ovelles blanques, {Negres} ovelles negres i {Blanc_i_Negre} ovelles blanques i negres");

    }

}