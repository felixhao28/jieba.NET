using JiebaNet.Segmenter;
using System;

namespace DotnetCore.Segmenter.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var segmenter = new JiebaSegmenter();
            var r = segmenter.Cut("大家好，我叫小娜。");
            Console.WriteLine(String.Join(',', r));
        }
    }
}