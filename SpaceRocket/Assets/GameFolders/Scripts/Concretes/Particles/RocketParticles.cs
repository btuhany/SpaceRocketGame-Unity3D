using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Particles
{
    public class RocketParticles : MonoBehaviour
    {
        PlayerController _player;
        private void Awake()
        {
            _player= GetComponent<PlayerController>();
        }


    }

}
