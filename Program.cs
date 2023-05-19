using System;

class Program
{
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }

    static void Main(string[] args)
    {
        char continueProgram = 'Y';

        while (continueProgram == 'Y')
        {
            Console.Write("Enter half DNA sequence: ");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNASequence);
                Console.Write("Do you want to replicate it? (Y/N): ");
                char replicateChoice = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (replicateChoice == 'Y')
                {
                    string replicatedSequence = ReplicateSeqeunce(halfDNASequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (replicateChoice == 'N')
                {
                    // Skip replication
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            continueProgram = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (continueProgram != 'Y' && continueProgram != 'N')
            {
                Console.WriteLine("Please input Y or N.");
                continueProgram = 'Y';
            }
        }
    }
}
