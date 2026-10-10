using System.Reflection.Metadata.Ecma335;

namespace ElectionVoteCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        
                        if(votes.ContainsKey(line[0]))
                            votes[line[0]] += int.Parse(line[1]);
                        else
                            votes[line[0]] = int.Parse(line[1]);
                    }

                    foreach (KeyValuePair<string, int> item in votes)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}