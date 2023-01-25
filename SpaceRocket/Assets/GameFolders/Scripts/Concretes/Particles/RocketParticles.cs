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
        [SerializeField] ParticleSystem _rotatingParticle;
        [SerializeField] ParticleSystem _overHeatFireParticle;
        [SerializeField] ParticleSystem _overHeatStartParticle;
        [SerializeField] ParticleSystem _gameOverParticle;

        public ParticleSystem FireUpParticle { get => _fireUpParticle; set => _fireUpParticle = value; }
        public ParticleSystem OverHeatingParticle { get => _overHeatFireParticle; set => _overHeatFireParticle = value; }
        public ParticleSystem OverHeatStartParticle { get => _overHeatStartParticle; set => _overHeatStartParticle = value; }
        public ParticleSystem GameOverParticle { get => _gameOverParticle; set => _gameOverParticle = value; }
        public ParticleSystem RotatingParticle { get => _rotatingParticle; set => _rotatingParticle = value; }

        private void Awake()
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
