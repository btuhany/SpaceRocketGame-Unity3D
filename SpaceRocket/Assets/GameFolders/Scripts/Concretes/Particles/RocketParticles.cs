using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace Particles
{
    public class RocketParticles : MonoBehaviour
    {
        
        [SerializeField] ParticleSystem _fireUpParticle;
        [SerializeField] ParticleSystem _overHeatFireParticle;

        public ParticleSystem FireUpParticle { get => _fireUpParticle; set => _fireUpParticle = value; }
        public ParticleSystem OverHeatFireParticle { get => _overHeatFireParticle; set => _overHeatFireParticle = value; }

        private void OnEnable()
        {
            _fireUpParticle.Stop();
            _overHeatFireParticle.Stop();
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
