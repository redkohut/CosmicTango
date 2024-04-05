using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CosmicTango.Data;


namespace CosmicTango.ObstacleSpawner
{
    public class ObstacleWave : MonoBehaviour
    {
        #region Variables
        /***
         * We have several types of initialized gameObjects
         * -----------------------------------------------------
         * 1. Coins --- add +1 valueCoin
         * 2. ProtectRube --- 10 seconds absolutely defense
         * 3. SpeedBoost --- 10 seconds X2 Speed of GameProcess
         * -----------------------------------------------------
         * 4. CoinBoost2x --- 30 seconds X2 collected coins
         * 5. CoinBoost4x --- 20 seconds X4 collected coins
         * 6. CoinBoost8x --- 15 seconds X8 collected coins
         * -----------------------------------------------------
         * 7. BlackHole --- instant death
         * 8. Meteorites<list> --- minus one health point --
         * -----------------------------------------------------
         * 9. Cartridges --- add +1 cartr.
         * 10. Health --- add +1 health point
         * ----------------------------------------------------- ***/
        private GameObject _coin; // 1
        private GameObject _protectRube; // 2
        private GameObject _speedBoost; // 3
        private GameObject _coinBoost2X; // 4
        private GameObject _coinBoost4X; // 5
        private GameObject _coinBoost8X; // 6
        private GameObject _blackHole; // 7
        private List<GameObject> _meteorites = new List<GameObject>(); // 8
        private GameObject _cartridge; // 9
        private GameObject _health; // 10


        public ObstaclesData obstaclesData;
        // and we have a trigger zone for counting arrived zones
        

        #endregion
        void Start()
        {
            // Load all resources
            SetAllObstacles();
        }

        // Update is called once per frame
        void Update()
        {

        }


        private void SetAllObstacles()
        {
            // set all prefabes
            _coin = obstaclesData.coin;
            _protectRube = obstaclesData.protectRube;
            _speedBoost = obstaclesData.speedBoost;
            _coinBoost2X = obstaclesData.coinBoost2X;
            _coinBoost4X = obstaclesData.coinBoost4X;
            _coinBoost8X = obstaclesData.coinBoost8X;
            _blackHole = obstaclesData.blackHole;
            _meteorites = obstaclesData.meteorites;
            _cartridge = obstaclesData.cartridge;
            _health = obstaclesData.health;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Wave");
        }
    }
}

