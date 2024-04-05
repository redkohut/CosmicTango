using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicTango.Data
{
    [CreateAssetMenu(fileName = "NewObstaclesData", menuName = "ObstaclesData")]
    public class ObstaclesData : ScriptableObject
    {
        public GameObject coin; // 1
        public GameObject protectRube; // 2
        public GameObject speedBoost; // 3
        public GameObject coinBoost2X; // 4
        public GameObject coinBoost4X; // 5
        public GameObject coinBoost8X; // 6
        public GameObject blackHole; // 7
        public List<GameObject> meteorites = new List<GameObject>(); // 8
        public GameObject cartridge; // 9
        public GameObject health; // 10
    }
}

