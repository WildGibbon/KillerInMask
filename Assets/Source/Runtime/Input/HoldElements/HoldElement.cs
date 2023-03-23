using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KillerInMask.Model.UI
{
	internal class HoldElement : MonoBehaviour, IHoldElement, IPointerDownHandler, IPointerUpHandler
	{
		public bool IsHold { get; private set; }

		public void OnPointerDown(PointerEventData eventData)
		{
			IsHold = true;
		}

		public void OnPointerUp(PointerEventData eventData)
		{
			IsHold = false;
		}
	}
}
