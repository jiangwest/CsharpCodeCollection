//抽取脚本中的函数定义
//其中函数定义以 keyword function开始，格式: function Type funcName([Type param]*);
//1. 提取函数
//2. 删除 keyword function
//3. 给每个函数变量添加编号
// example I: function bool test(int a,int b, string c);
//转换为 test(1 int a,2 int b,3 string c);
// example II: function bool test();
//转换为 bool test();
class Program
{
    static void Main(string[] args)
    {
        //简单MatchEvaluator应用
        string s = "1 12 3 5";
        s = Regex.Replace(s, @"\d+", new MatchEvaluator(CorrectString), RegexOptions.IgnoreCase);
        Console.WriteLine(s);

        //process function style,
        //1. find function key and its declaration
        //2. delete function key
        //3. give number serial to each parameters of function
        //e.g. extract the string like "function test(...)"
        string str = "int i1;       function bool test(int a,int b, string c);";
        str = Regex.Replace(str, @"\sfunction\s+[^;]+", new MatchEvaluator(procFuncTest), RegexOptions.IgnoreCase);
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

    //处理function
    private static string procFuncTest(Match match)
    {
        string matchStr = match.Value;
        string retStr;  //返回值
        
        //1. find & delete function key
        matchStr = Regex.Replace(matchStr, @"\sfunction\s", "", RegexOptions.IgnoreCase);
        //分割函数声明
        string[] split = matchStr.Split(new string[] { ",", "(",")" }, StringSplitOptions.RemoveEmptyEntries);
        //处理函数名+(
        retStr = split[0] + "(";

        //split[]从1~length-1 为函数中参数声明
        for (int i = 1; i < split.Length; i++)
        {
            if(i == split.Length - 1)
                split[i] = i + " " + split[i];  //最后一个参数后无需加
            else
                split[i] = i + " " + split[i] +",";

            retStr += split[i];
        }
        
        retStr += ")";  //处理函数结尾
        
        return retStr;
    }
}
