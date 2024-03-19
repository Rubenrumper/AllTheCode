static class Opgave
{
    static void Main()
    {
        {
            string[] array = ["nul", "et", "to"];
            int[] cat = new int[7];
        }

        b();

        c();

        d();
        
        e();


        static void b()
        {
            string[] cats = ["cat", "cats"];
            cats[0] = "best cats";
            Console.WriteLine(cats[0]);
        }

        static void c()
        {
            string[] morecats = new string[4];
            morecats[1] = "cater";
            morecats[2] = "catine";
            Console.WriteLine($"catOne:{morecats[0]}, catTwo:{morecats[1]}, catThree:{morecats[2]}");
        }

        static void d()
        {
            string[] cates = ["Jane", "John", "James", "Oliver"];
            Console.WriteLine($"The length of the array is {cates.Length}");
            for (int i = 0; i < cates.Length; i++)
            {
                Console.WriteLine($"Name at index {i} is {cates[i]}");
            }
        }

        static void e()
        {
            string[][] caters = [["Tove", "Luna"], ["Daisy", "Reinhardt"], ["Finn"]];
            for (int i = 0; i < caters.Length; i++)
            {
                for (int j = 0; j < caters[i].Length; j++)
                {
                    Console.Write(caters[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}