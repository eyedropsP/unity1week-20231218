namespace Eyedrops.Data
{
    /// <summary>
    /// プレイヤーを表します。
    /// </summary>
    public readonly struct CharacterPoint
    {
        /// <summary>
        /// 現在の座標
        /// </summary>
        public FieldPoint CurrentPoint { get; }


        /// <summary>
        /// インスタンスを生成します。
        /// </summary>
        /// <param name="currentPoint"></param>
        public CharacterPoint(FieldPoint currentPoint)
            => this.CurrentPoint = currentPoint;


        /// <summary>
        /// 指定された座標に移動します。
        /// </summary>
        /// <param name="dist"></param>
        /// <returns></returns>
        public CharacterPoint Move(FieldPoint dist)
            => new(this.CurrentPoint + dist);
    }
}