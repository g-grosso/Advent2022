using StreamReader infile = File.OpenText("input01.txt");
{
    List<int> e = new List<int>();
    String? s;
    int amt = 0;
    int topN = 3;
    while ((s=infile.ReadLine())!= null){
        if(s!=""){
            amt+=(int.Parse(s));
        }
        else{
            e.Add(amt);
            amt=0;
        }
    }
    int sum = e.OrderByDescending(x=>x).ToList().GetRange(0,topN).Sum();
    Console.WriteLine(sum);
}
