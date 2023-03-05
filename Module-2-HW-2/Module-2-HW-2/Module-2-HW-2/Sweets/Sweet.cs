namespace Module_2_HW_2.Sweets;

public abstract class Sweet
{
	protected string _name;
	protected decimal _weight;

	public Sweet(string name)
	{
		_name = name;
	}

	public string Name
	{
		get
		{
			return _name;
		}
	}


	public decimal Weight
	{
		get
		{
			return _weight;
		}
		set
		{
			_weight = value;
		}
	}

}
