using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MaskedKiller.View.Gun
{
	public interface IBulletView
	{
		//убрать это говно
		void Visualize(Vector2 direction, Quaternion rotation);
	}
}
