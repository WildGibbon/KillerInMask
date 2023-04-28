using MaskedKiller.Model.Selector;
using System;

namespace MaskedKiller.Model.UI.Buttons
{
	public class NextNextItemButton<T> : IButton
	{
		private readonly ISelector<T> _selector;

		public NextNextItemButton(ISelector<T> selector)
		{
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
		}

		public void Press()
		{
			_selector.NextItem();
		}
	}
}
