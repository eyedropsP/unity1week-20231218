using System;
using Eyedrops.Data.Fields;
using UnityEngine;

namespace Eyedrops.Data.Enemy
{
    [Serializable]
    public sealed class Enemy
    {
        public int Hp;

        public int Attack;

        public int Magic;

        public FieldPoint DefaultPoint => _defaultPoint;

        [SerializeField]
        private FieldPoint _defaultPoint;


        public Enemy(sbyte x, sbyte y)
        {
            _defaultPoint = new FieldPoint(x, y);
        }
    }
}