using MaskedKiller.Model.UI.Buttons;
using UnityEngine;
using System;

namespace MaskedKiller.Model.UI
{
	public class PCButton : MonoBehaviour, IUIButton
	{
		[SerializeField] private KeyCode _buttonCode;

		private IButton _button;

		public void Init(IButton button)
		{
			_button = button ?? throw new ArgumentNullException(nameof(button));
		}

		private void Update()
		{
			if (UnityEngine.Input.GetKeyDown(_buttonCode))
				_button.Press();
		}
	}
}
