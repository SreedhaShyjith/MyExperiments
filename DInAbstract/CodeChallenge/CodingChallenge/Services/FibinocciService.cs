using CodingChallenge.Models;
using System;
using System.Collections.Generic;

namespace CodingChallenge.IServices
{
    public class FibanocciService : IFibinocciService
    {/// <summary>
     /// Generate Fibinocci series with the length of array same as num
     /// </summary>
     /// <param name="num"></param>
     /// <returns></returns>
        public Fibonacci GenerateFebinocciSeries(int? num)
        {
            Fibonacci FibonacciResponse = new Fibonacci();
            if (num > 0)
            {
                int[] series = new int[1];
                Array.Resize(ref series, Convert.ToInt32(num));

                series[0] = 0;
                series[1] = 1;

                for (int i = 2; i < num; i++)
                    series[i] = series[i - 1] + series[i - 2];
                FibonacciResponse.FibonacciSequence = series;
                FibonacciResponse.Message = "Success";
            }
            else
            {
                FibonacciResponse.Message = "Please enter a numeric value greater than 0.";
            }

            return FibonacciResponse;
        }
    }
}
