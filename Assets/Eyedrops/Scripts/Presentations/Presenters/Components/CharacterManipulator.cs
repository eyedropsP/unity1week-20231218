using Eyedrops.Scripts.Presenters.Components;
using R3;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Eyedrops.Presentations.Presenters.Components
{
    /// <summary>
    /// キャラクターの操作を提供します。
    /// </summary>
    public sealed class CharacterManipulator
    {
        /// <summary>
        /// 移動方向を取得します。
        /// </summary>
        public ReadOnlyReactiveProperty<Vector2> Direction => _direction.ToReadOnlyReactiveProperty();

        private readonly ReactiveProperty<Vector2> _direction = new();

        /// <summary>
        /// アクションボタンが押されたかどうかを判定します。
        /// </summary>
        public Observable<Unit> Fire => _fire;

        private readonly Subject<Unit> _fire = new();


        /// <summary>
        /// インスタンスを生成します。
        /// </summary>
        /// <param name="playerInputActions"></param>
        public CharacterManipulator(PlayerInputActions playerInputActions)
        {
            playerInputActions.Enable();
            playerInputActions.Player.Move.started += context =>
            {
                var value = context.ReadValue<Vector2>();
                _direction.OnNext(value);
            };

            playerInputActions.Player.Fire.performed += context =>
            {
                if (context.phase == InputActionPhase.Performed)
                    _fire.OnNext(Unit.Default);
            };
        }
    }
}