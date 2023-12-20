namespace Eyedrops.Data
{
    /// <summary>
    /// フィールドを表します。
    /// </summary>
    public readonly struct FieldPoint
    {
        /// <summary>
        /// X 座標
        /// </summary>
        public sbyte X { get; }

        /// <summary>
        /// Y 座標
        /// </summary>
        public sbyte Y { get; }


        /// <summary>
        /// インスタンスを生成します。
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public FieldPoint(sbyte x, sbyte y)
        {
            X = x;
            Y = y;
        }


        /// <summary>
        /// 加算します。
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static FieldPoint operator +(FieldPoint a, FieldPoint b)
            => new((sbyte) (a.X + b.X), (sbyte) (a.Y + b.Y));


        /// <summary>
        /// 減産します。
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static FieldPoint operator -(FieldPoint a, FieldPoint b)
            => new((sbyte) (a.X - b.X), (sbyte) (a.Y - b.Y));
    }
}