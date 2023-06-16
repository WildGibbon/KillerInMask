using MaskedKiller.Model.Selector;
using System;

namespace MaskedKiller.Model.UI.Buttons
{
	public class NextItemButton<T> : IButton
	{
		private readonly ISelector<T> _selector;

		public NextItemButton(ISelector<T> selector)
		{
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
		}

		public void Press()
		{
			_selector.NextItem();
		}
	}
}
