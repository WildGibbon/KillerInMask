using MaskedKiller.Model.UI;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MaskedKiller.Game.Data.UI
{
	public class UIButtons : SerializedMonoBehaviour, IUIButtons
	{
		[field: SerializeField] public IUIButton PreviousWeaponButton { get; private set; }
		[field: SerializeField] public IUIButton NextWeaponButton { get; private set; }

		[field:SerializeField] public IUIButton WeaponAttackButton { get; private set; }
		[field: SerializeField] public IUIButton JumpButton { get; private set; }

	}
}
