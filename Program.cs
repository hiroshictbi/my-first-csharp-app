// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("C# の学習、頑張りましょう！");
// Program.cs
using System; // この行は通常最初からあります

namespace HelloWorldApp // この行はプロジェクトによって異なる場合があります
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("あなたの名前を入力してください:");
            string userName = Console.ReadLine(); // ユーザーの名前を読み込む

            Console.WriteLine($"こんにちは、{userName}さん！"); // 入力された名前を表示
            Console.WriteLine("C# の学習、頑張りましょう！");
        }
    }
}