namespace Module_2_HW_2.Sweets;

public abstract class Candy : Sweet
{
    public Candy(string name, bool isLactoseFree) : base(name)
    {
        IsLactoseFree = isLactoseFree;
    }
    public bool IsLactoseFree { get; set; }

}
