using UnityEngine;

namespace Eyedrops.Data.Enemy
{
    /// <summary>
    /// 敵出現のウェーブを表します。
    /// </summary>
    [CreateAssetMenu(fileName = "EnemyWave", menuName = "ScriptableObjects/EnemyWave", order = 1)]
    public sealed class EnemyWave : ScriptableObject
    {
        /// <summary>
        /// 敵の遭遇
        /// </summary>
        public EnemyEncounterRelation[] EnemyEncounterRelations => _enemyEncounterRelations;
        
        
        [SerializeField]
        private EnemyEncounterRelation[] _enemyEncounterRelations;
    }
}