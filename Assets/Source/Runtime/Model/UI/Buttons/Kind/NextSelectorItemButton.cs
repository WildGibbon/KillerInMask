using MaskedKiller.Model.Selector;
using System;

namespace MaskedKiller.Model.UI.Buttons
{
	public class NextSelectorItemButton<T> : IButton
	{
		private readonly ISelector<T> _selector;

		public NextSelectorItemButton(ISelector<T> selector)
		{
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
		}

		public void Press()
		{
			_selector.NextItem();
		}
	}
}
