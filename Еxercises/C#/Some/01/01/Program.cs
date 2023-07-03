class Program
{
    static void Main()
    {
        Console.Write("Number of suspects: ");
        int n = int.Parse(Console.ReadLine());

        List<string> suspects = new List<string>();
        List<string> statements = new List<string>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Suspect's name: ");
            string name = Console.ReadLine();
            suspects.Add(name);

            Console.Write("Statement: ");
            string statement = Console.ReadLine();
            statements.Add(statement);
        }

        string guiltySuspect = FindGuiltySuspect(suspects, statements);

        Console.WriteLine("The guilty suspect is: " + guiltySuspect);
    }

    static string FindGuiltySuspect(List<string> suspects, List<string> statements)
    {
        for (int i = 0; i < statements.Count; i++)
        {
            if (statements[i].ToLower() != "i am innocent.")
            {
                string theMainSuspect = statements[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).First();

                foreach (var person in suspects)
                {
                    if (person.ToLower() == theMainSuspect.ToLower())
                    {
                        return theMainSuspect;
                    }
                }
            }
        }
        return "There are no suspects";
    }
}
