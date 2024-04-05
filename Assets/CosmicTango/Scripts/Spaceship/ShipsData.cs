using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CosmicTango.Data
{
    [CreateAssetMenu(fileName = "NewShipsData", menuName = "ShipsData")]
    public class ShipsData : ScriptableObject
    {
        public List<ShipData> ships = new List<ShipData>();
    }

}
