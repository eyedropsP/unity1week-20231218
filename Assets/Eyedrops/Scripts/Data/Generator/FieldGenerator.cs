using UnityEngine;
using UnityEngine.Tilemaps;

namespace Eyedrops.Data.Generator
{
    public sealed class FieldGenerator : MonoBehaviour
    {
        [SerializeField]
        private Tilemap _tileMap;

        [SerializeField]
        private Tile _tile;


        private void Start()
        {
            _tileMap.SetTile(new Vector3Int(0, 0), _tile);
        }
    }
}