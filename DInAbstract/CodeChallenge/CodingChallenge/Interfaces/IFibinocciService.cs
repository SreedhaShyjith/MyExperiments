using CodingChallenge.Models;

namespace CodingChallenge.IServices
{
    public interface IFibinocciService
    {
        Fibonacci GenerateFebinocciSeries(int? num);
    }
}
