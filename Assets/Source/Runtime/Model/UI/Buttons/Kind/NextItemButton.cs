using MaskedKiller.Model.Character;
using MaskedKiller.Model.Selector;
using System;

namespace MaskedKiller.Model.UI.Buttons
{
	public class NextItemButton : IButton
	{
		private readonly ISelector _selector;

		public NextItemButton(ISelector selector)
		{
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
		}

		public void Press()
		{
			_selector.NextItem();
		}
	}
}
