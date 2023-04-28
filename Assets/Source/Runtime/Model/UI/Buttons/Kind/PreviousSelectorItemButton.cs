using MaskedKiller.Model.Selector;
using System;

namespace MaskedKiller.Model.UI.Buttons.Kind
{
	public class PreviousSelectorItemButton<T> : IButton
	{
		private readonly ISelector<T> _selector;

		public PreviousSelectorItemButton(ISelector<T> selector)
		{
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
		}

		public void Press()
		{
			_selector.PreviousItem();
		}
	}
}
