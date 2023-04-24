namespace MaskedKiller.Model.Selector
{
	public interface ISelector<T>
	{
		T CurrrentItem { get; }
		void PreviousItem();
		void NextItem();
	}
}
