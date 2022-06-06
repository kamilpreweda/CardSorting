using Cards;

namespace CardSorting
{
    public class Program
    {

        private static readonly Random random = new Random();

        
        static Card RandomCard()
        {
            return new Card((Values)random.Next(1, 14), (Suits)random.Next(4));
        }

        static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }

        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
        }
    }
}