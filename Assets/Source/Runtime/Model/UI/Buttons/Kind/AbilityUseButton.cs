using MaskedKiller.Model.Ability;
using MaskedKiller.Model.Selector;
using System;

namespace MaskedKiller.Model.UI.Buttons
{
	public class AbilityUseButton : IButton
	{
		private readonly ISelector<IAbility> _selector;

		public AbilityUseButton(ISelector<IAbility> selector)
		{
			_selector = selector ?? throw new ArgumentNullException(nameof(selector));
		}

		public void Press()
		{
			_selector.CurrrentItem.Use();
		}
	}
}
