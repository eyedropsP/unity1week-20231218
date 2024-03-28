using UnityEngine;

namespace Eyedrops.Presentations.Views
{
    /// <summary>
    /// キャラクターのビューを表します。
    /// </summary>
    public sealed class CharacterView : MonoBehaviour
    {
        /// <summary>
        /// キャラクターのスプライトを表します。
        /// </summary>
        [SerializeField]
        private Sprite[] _characterSprites;

        /// <summary>
        /// 下方向のスプライトの先頭フレーム
        /// </summary>
        [SerializeField]
        private short _downHeadIndex;

        /// <summary>
        /// 左方向のスプライトの先頭フレーム
        /// </summary>
        [SerializeField]
        private short _leftHeadIndex;

        /// <summary>
        /// 右方向のスプライトの先頭フレーム
        /// </summary>
        [SerializeField]
        private short _rightHeadIndex;

        /// <summary>
        /// 上方向のスプライトの先頭フレーム
        /// </summary>
        [SerializeField]
        private short _upHeadIndex;
        
        /// <summary>
        /// スプライトアニメーションのフレームレート
        /// </summary>
        [SerializeField]
        private int _spriteFrameRate = 10;


        /// <summary>
        /// 次の座標に移動します。
        /// </summary>
        /// <param name="direction"></param>
        public void MoveNextPoint(Vector2 direction)
        {
            var self = this.transform;
            var nextPosition = self.position + (Vector3)direction;
            self.position = nextPosition;
        }
    }
}