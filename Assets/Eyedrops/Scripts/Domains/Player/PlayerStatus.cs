using Eyedrops.Data.Fields;
using R3;


namespace Eyedrops.Domains.Player
{
    /// <summary>
    /// プレイヤーの状態を表します。
    /// </summary>
    public sealed class PlayerStatus
    {
        /// <summary>
        /// 体力
        /// </summary>
        public ReadOnlyReactiveProperty<int> Hp => _hp;

        private readonly ReactiveProperty<int> _hp = new();
        
        /// <summary>
        /// 攻撃力
        /// </summary>
        public ReadOnlyReactiveProperty<int> Attack => _attack;
        
        private readonly ReactiveProperty<int> _attack = new();
        
        /// <summary>
        /// 魔力
        /// </summary>
        public ReadOnlyReactiveProperty<int> Magic => _magic;
        
        private readonly ReactiveProperty<int> _magic = new();

        /// <summary>
        /// 現在の座標
        /// </summary>
        public ReadOnlyReactiveProperty<FieldPoint> CurrentPoint => _currentPoint;

        private readonly ReactiveProperty<FieldPoint> _currentPoint = new();


        /// <summary>
        /// 指定された座標に移動します。
        /// </summary>
        /// <param name="point"></param>
        public void MoveNextPoint(FieldPoint point)
        {
            _currentPoint.Value = point;
        }
    }
}