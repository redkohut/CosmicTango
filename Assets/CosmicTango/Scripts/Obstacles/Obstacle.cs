using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


namespace CosmicTango.ObstacleSpawner
{
    public class Obstacle : MonoBehaviour
    {
        private enum ObstacleType { Coin, ProtectRube, SpeedBoost, Coin2, Coin4, Coin8, BlackHole, Meteor, Cartridge, Health}

        [SerializeField] private ObstacleType _obstacleType;
        

        private float _speed;
        private bool _crashed;


        private void OnTriggerEnter2D(Collider2D collision)
        {

            _crashed = true;
        }
    }
}
