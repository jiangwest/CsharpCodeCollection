class Program
{
    static void Main(string[] args)
    {
        string s = "1 12 3 5";
        s = Regex.Replace(s, @"\d+", new MatchEvaluator(CorrectString), RegexOptions.Compiled | RegexOptions.IgnoreCase);
        Console.WriteLine(s);

        //process function style,
        //1. find function key and its declaration
        //2. delete function key
        //3. give number serial to each parameters of function
        //e.g. extract the string like "function test(...)"
        string str = "int i1;       function test(int a,int b, string c);";
        str = Regex.Replace(str, @"\sfunction\s+[^;]+", new MatchEvaluator(procFuncTest), RegexOptions.Compiled | RegexOptions.IgnoreCase);
        Console.WriteLine(str);
        Console.ReadLine();
    }

    private static string CorrectString(Match match)
    {
        string matchValue = match.Value;
        if (matchValue.Length == 1)
            matchValue = "0" + matchValue;
        return matchValue;
    }

    private static string procFuncTest(Match match)
    {
        string matchStr = match.Value;
        string retStr;

        //1. delete function key
        matchStr = Regex.Replace(matchStr, @"\sfunction\s", "", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        string[] split = matchStr.Split(new string[] { ",", "(",")" }, StringSplitOptions.RemoveEmptyEntries);
        retStr = split[0] + "(";

        foreach (string s in split)
            Console.WriteLine(s);

        for (int i = 1; i < split.Length; i++)
        {
            if(i == split.Length - 1)
                split[i] = i + " " + split[i];
            else
                split[i] = i + " " + split[i] +",";

            retStr += split[i];
        }

        retStr += ")";

        return retStr;
    }
