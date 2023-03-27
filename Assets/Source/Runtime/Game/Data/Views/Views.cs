﻿using MaskedKiller.Game.Data.UI;
using MaskedKiller.View.Health;
using MaskedKiller.View.Movement;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MaskedKiller.Game.Data.Views
{
	public class Views : SerializedMonoBehaviour, IViews
	{
		[field: SerializeField] public IHealthView HealthView { get; private set; }
		[field: SerializeField] public IMovementView MovementView { get; private set; }
	}
}
