using System;
using UnityEngine;

namespace Eyedrops.Data.Fields
{
    /// <summary>
    /// フィールドを表します。
    /// </summary>
    [Serializable]
    public struct FieldPoint
    {
        /// <summary>
        /// X 座標
        /// </summary>
        public sbyte X => _x;

        [SerializeField]
        private sbyte _x;

        /// <summary>
        /// Y 座標
        /// </summary>
        public sbyte Y => _y;

        [SerializeField]
        private sbyte _y;


        /// <summary>
        /// インスタンスを生成します。
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public FieldPoint(sbyte x, sbyte y)
        {
            _x = x;
            _y = y;
        }


        /// <summary>
        /// インスタンスを生成します。
        /// </summary>
        /// <param name="point"></param>
        public FieldPoint(Vector2 point)
        {
            _x = (sbyte)point.x;
            _y = (sbyte)point.y;
        }


        /// <summary>
        /// 加算します。
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static FieldPoint operator +(FieldPoint a, FieldPoint b)
            => new((sbyte)(a.X + b.X), (sbyte)(a.Y + b.Y));


        /// <summary>
        /// 減産します。
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static FieldPoint operator -(FieldPoint a, FieldPoint b)
            => new((sbyte)(a.X - b.X), (sbyte)(a.Y - b.Y));
    }
}