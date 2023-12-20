using UniRx;

namespace Eyedrops.Data
{
    /// <summary>
    /// キャラクターを表します。
    /// </summary>
    public sealed class Character
    {
        /// <summary>
        /// 体力
        /// </summary>
        public IReadOnlyReactiveProperty<int> Hp => _hp;

        private readonly ReactiveProperty<int> _hp = new();

        /// <summary>
        /// 現在の座標
        /// </summary>
        public IReadOnlyReactiveProperty<CharacterPoint> CurrentPoint => _currentPoint;

        private readonly ReactiveProperty<CharacterPoint> _currentPoint = new();
        
        
        
    }
}