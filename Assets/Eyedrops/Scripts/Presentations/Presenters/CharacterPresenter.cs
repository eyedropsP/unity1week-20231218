using Eyedrops.Data.Fields;
using Eyedrops.Domains.Player;
using Eyedrops.Presentations.Presenters.Components;
using Eyedrops.Presentations.Views;
using Eyedrops.Scripts.Presenters.Components;
using UnityEngine;
using R3;

namespace Eyedrops.Presentations.Presenters
{
    /// <summary>
    /// キャラクターのプレゼンターを表します。
    /// </summary>
    public sealed class CharacterPresenter : MonoBehaviour
    {
        [SerializeField]
        private CharacterView _characterView;

        private readonly PlayerStatus _playerStatus = new();

        private CharacterManipulator _characterManipulator;


        private void Awake()
        {
            _characterManipulator = new CharacterManipulator(new PlayerInputActions());

            _characterManipulator.Direction
                .Skip(1)
                .Subscribe(state: (_playerStatus, _characterView), static (direction, state) =>
                {
                    var (playerStatus, characterView) = state;
                    var nextPoint = new FieldPoint(direction);
                    playerStatus.MoveNextPoint(nextPoint);
                    characterView.MoveNextPoint(direction);
                })
                .AddTo(this);

            _characterManipulator.Fire
                .Subscribe(_ => { })
                .AddTo(this);
        }
    }
}