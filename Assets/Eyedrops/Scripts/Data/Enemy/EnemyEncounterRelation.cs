using System;
using UnityEngine;

namespace Eyedrops.Data.Enemy
{
    /// <summary>
    /// プレイヤーレベルに応じた敵の遭遇を表します。
    /// </summary>
    [Serializable]
    public class EnemyEncounterRelation
    {
        /// <summary>
        /// プレイヤーレベル
        /// </summary>
        public int PlayerLevel => _playerLevel;
        
        [SerializeField]
        private int _playerLevel;

        public Enemy[] Enemies => _enemies;

        [SerializeField]
        private Enemy[] _enemies;
    }
}