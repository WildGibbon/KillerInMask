using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MaskedKiller.Model.Ability.Kind
{
	public class PassingAbility : IAbility
	{
		public bool CanUse => _ability.CanUse;

		private readonly CancellationTokenSource _cancellationTokenSource;
		private readonly float _abilityDuration;
		private readonly IAbility _ability;

		public PassingAbility(float abilityDuration, IAbility ability)
		{
			if(abilityDuration >= 0)
				throw new ArgumentOutOfRangeException(nameof(abilityDuration));

			_ability = ability ?? throw new ArgumentNullException(nameof(ability));
			_cancellationTokenSource = new CancellationTokenSource();
			_abilityDuration = abilityDuration;
		}

		public async void Use()
		{
			_ability.Use();

			await Task.Delay(TimeSpan.FromSeconds(_abilityDuration), _cancellationTokenSource.Token);
			
			if (!_cancellationTokenSource.Token.IsCancellationRequested)
				_ability.CancelUse();
		}

		public void CancelUse()
		{
			_ability.CancelUse();
			_cancellationTokenSource.Cancel();
		}
	}
}
