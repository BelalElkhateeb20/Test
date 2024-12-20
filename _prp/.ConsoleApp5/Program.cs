namespace ConsoleApp5.Prop_indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phonebook ob1=new Phonebook(5);
            ob1.entryRange(0, "Abc", 010200000);
            ob1.entryRange(1, "ADFR", 111188);
            ob1.entryRange(2, "GTFD", 1880);

            ob1["ADFR"] =1254;
            ob1[1, "ADFR"] =1254;

           
            Console.WriteLine(ob1["GTFD"]);
            //Console.WriteLine(ob1);
            //ob1.entry(4, "n344rn",0100110);
            //Console.WriteLine(ob1.GetNumber("Abc"));
            Console.ReadLine(); 

        }
    }
}
