namespace MaskedKiller.Model.Selector
{
	public interface ISelector
	{
		dynamic CurrrentItem { get; }
		void PreviousItem();
		void NextItem();
	}
}
