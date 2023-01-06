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
        [SerializeField] ParticleSystem _overHeatStartParticle;

        public ParticleSystem FireUpParticle { get => _fireUpParticle; set => _fireUpParticle = value; }
        public ParticleSystem OverHeatingParticle { get => _overHeatFireParticle; set => _overHeatFireParticle = value; }
        public ParticleSystem OverHeatStartParticle { get => _overHeatStartParticle; set => _overHeatStartParticle = value; }

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
