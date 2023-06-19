using MaskedKiller.Model.UI.Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace MaskedKiller.Model.UI
{
	[RequireComponent(typeof(Button))]
	public class MobileUIButton : MonoBehaviour, IUIButton
	{
		private Button _unityButton;
		private IButton _button;

		public void Init(IButton button)
		{
			_button = button;

			_unityButton = GetComponent<Button>();
			_unityButton.onClick.AddListener(_button.Press);
		}
	}
}
