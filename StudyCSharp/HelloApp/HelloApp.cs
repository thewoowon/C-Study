using static System.Console;

/// <summary>
///  Hello Guys! i've wanted to talk about our team's main event project!. we check the project everyday that as well as we can do 
/// </summary>


namespace HelloApp
{
    class HelloApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("사용법 : helloapp.exe <이름>");
                return;
            }
            WriteLine($"Hello, {args[0]}!");
        }
    }
}
