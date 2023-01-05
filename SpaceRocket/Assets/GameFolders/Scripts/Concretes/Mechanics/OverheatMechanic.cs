using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Particles;
namespace Mechanics 
{
    public class OverheatMechanic : MonoBehaviour
    {
        [SerializeField] float _maxHeat=100f;
        [SerializeField] float _currentHeat;
        [SerializeField] float _heatIncreaseSpeed;
        [SerializeField] float _heatDecreaseSpeed;

        RocketParticles _particles;
        public bool IsOverHeated => _currentHeat > _maxHeat;

        private void Awake()
        {
            _particles = GetComponent<RocketParticles>();
        }
        public void HeatIncrease()
        {
            _currentHeat += _heatIncreaseSpeed;
            _currentHeat = Mathf.Min(_currentHeat, _maxHeat+1f);
            

        }

        public void HeatDecrease()
        {
            _currentHeat -= _heatDecreaseSpeed;
            _currentHeat = Mathf.Max(_currentHeat, 0f);
 
        }
        public void OverHeating()
        {
            _currentHeat += _heatIncreaseSpeed*(_heatIncreaseSpeed-_heatDecreaseSpeed);
            _particles.PlayIfStopped(_particles.OverHeatFireParticle);
        }
    }
}

