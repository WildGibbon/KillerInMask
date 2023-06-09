﻿using UnityEngine.UI;
using UnityEngine;

namespace MaskedKiller.View.Mana
{
	public class ManaStorageView : MonoBehaviour, IManaStorageView
	{
		[SerializeField] private Slider _slider;

		private void Awake()
		{
			_slider = GetComponent<Slider>();
		}

		public void Visualize(int currrentValue, int maxValue)
		{
			_slider.maxValue = maxValue;
			_slider.value = currrentValue;
		}
	}
}
