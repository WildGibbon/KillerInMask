using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MaskedKiller.View.Bullets
{
	public class PositionCopypaster : MonoBehaviour
	{
		[SerializeField] private GameObject _positionCopyObject;

		private void Update()
		{
			transform.position = _positionCopyObject.transform.position;
		}
	}
}
