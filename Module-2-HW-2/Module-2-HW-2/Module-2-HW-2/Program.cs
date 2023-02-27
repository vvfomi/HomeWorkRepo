using Module_2_HW_2.Sweets;

namespace Module_2_HW_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chocolate = new ChocolateCandy("Choco-coco")
            {
                Weight = 35
            };

            var chocolate2 = new ChocolateCandy("Daisy")
            {
                Weight = 30
            };

            var gelatin = new GelatinCandy("Crazy bee")
            {
                Weight = 15
            };
            var gelatin2 = new GelatinCandy("Lovely cow")
            {
                Weight = 20
            };

            var sugar = new SugarCandy("Lolly pop")
            {
                Weight = 20
            };
            var sugar2 = new SugarCandy("Sweet heart")
            {
                Weight = 40
            };

            try
            {
                Gift gift = new Gift(6);

                gift.AddSweet(chocolate);
                gift.AddSweet(sugar);
                gift.AddSweet(gelatin);
                gift.AddSweet(sugar2);
                gift.AddSweet(gelatin2);
                gift.AddSweet(chocolate2);

                Console.WriteLine($"Whole gift weight is: {gift.GiftWeight}g.");

                var sortedSweets = gift.GetSortedSweets();

                foreach (var sweet in sortedSweets)
                {
                    Console.WriteLine($"{sweet.Name} - {sweet.Weight} g.");
                }

                Console.WriteLine();

                Sweet[] lactoseFreeSweets = gift.GetLactoseFreeSweets();
                Console.WriteLine("Lactose free sweets are: ");
                foreach (Sweet sweet in lactoseFreeSweets)
                {
                    Console.WriteLine(sweet.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}