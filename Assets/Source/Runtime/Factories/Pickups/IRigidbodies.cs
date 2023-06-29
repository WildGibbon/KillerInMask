using System.Collections.Generic;
using UnityEngine;

namespace MaskedKiller.Factories.Pickups
{
	public interface IRigidbodies
	{
		IReadOnlyList<Rigidbody2D> Get { get; }
	}
}
