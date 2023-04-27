using MaskedKiller.Model.Character;
using MaskedKiller.Model.Selector;
using MaskedKiller.Model.Weapon;
using System;

namespace MaskedKiller.Model.UI.Buttons.Kind
{
	public class PreviousItemButton : IButton
	{
		private readonly ISelector _selector;

		public PreviousItemButton(ISelector selector)
		{
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
		}

		public void Press()
		{
			_selector.PreviousItem();
		}
	}
}
