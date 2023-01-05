using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace Particles
{
    public class RocketParticles : MonoBehaviour
    {
        PlayerController _player;
        [SerializeField] ParticleSystem _fireUpParticle;

        public ParticleSystem FireUpParticle { get => _fireUpParticle; set => _fireUpParticle = value; }

        private void Awake()
        {
            _player= GetComponent<PlayerController>();
        }
        public void PlayIfStopped(ParticleSystem _particle)
        {
            if(_particle.isStopped)
            {
                _particle.Play();
            }
        }
        public void StopIfPlaying(ParticleSystem _particle)
        {
            if (_particle.isPlaying)
            {
                _particle.Stop();
            }
        }


    }

}
