using Module_2_HW_2.Sweets;

namespace Module_2_HW_2;

public class Gift
{
    private Sweet[] _sweets;
    private int _sweetsArrayIndex = 0;

    public Gift(int sweetsAmount)
    {
        _sweets = new Sweet[sweetsAmount];
    }

    public void AddSweet(Sweet sweet)
    {
        if (_sweetsArrayIndex >= _sweets.Length)
        {
            throw new Exception("There is no free place! ");
        }

        _sweets[_sweetsArrayIndex] = sweet;
        _sweetsArrayIndex++;
    }

    public decimal GiftWeight
    {
        get
        {
            decimal giftWeight = 0;
            foreach (Sweet sweet in _sweets)
            {
                giftWeight += sweet.Weight;

            }
            return giftWeight;
        }
    }
    public Sweet[] GetSortedSweets()
    {
        Sweet[] sortedSweets = _sweets.OrderBy(x => x.Weight).ToArray();
        return sortedSweets;
    }

    public Sweet[] GetLactoseFreeSweets()
    {
        int lactoseFreeSweetsAmount = 0;

        for (int i = 0; i < _sweets.Length; i++)
        {
            Candy candy = _sweets[i] as Candy;
            if (candy.IsLactoseFree)
            {
                lactoseFreeSweetsAmount++;
            }
        }

        Sweet[] lactoseFreeSweets = new Sweet[lactoseFreeSweetsAmount];

        int index = 0;

        for (int i = 0; i < _sweets.Length; i++)
        {
            Candy candy = _sweets[i] as Candy;
            if (candy.IsLactoseFree)
            {
                lactoseFreeSweets[index] = candy;
                index++;
            }

        }
        return lactoseFreeSweets;

    }
}
