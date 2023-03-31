using MaskedKiller.Model.Weapon;
using MaskedKiller.View.Gun;
using UnityEngine;
using Sirenix.OdinInspector;
using MaskedKiller.Model.Attack;

namespace MaskedKiller.Factories
{
	public class BulletFactory : SerializedMonoBehaviour, IBulletFactory
	{
		[SerializeField] private GameObject _bulletPrefab;
		[SerializeField] private Transform _spawnPoint;
		[SerializeField] private float _throwForce;
		[SerializeField] private int _damage;

		public IBullet Create()
		{
			var bulletObject = Instantiate(_bulletPrefab, _spawnPoint.position, Quaternion.identity);
			var physicalAttack = bulletObject.GetComponent<PhysicalAttack>();
			var bulletView = bulletObject.GetComponent<BulletView>();

			physicalAttack.Init(new DefaultAttack(_damage));
			
			var bullet = new DefaultBullet(bulletView, _throwForce);


			return bullet;
		}
	}
}
