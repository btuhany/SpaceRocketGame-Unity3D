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
        private void Awake()
        {
            _particles = GetComponent<RocketParticles>();
        }

        public bool IsOverHeated
        {
            get
            {
                return _currentHeat > _maxHeat;
            }
        }

        public void HeatIncrease()
        {
            
            _currentHeat += _heatIncreaseSpeed;
           
            
        }

        public void HeatDecrease()
        {
            _currentHeat -= _heatDecreaseSpeed;
            _currentHeat = Mathf.Max(_currentHeat, 0f);
        }
        public void OverHeating()
        {
            
            _currentHeat += _heatIncreaseSpeed*1.2f;
            _currentHeat = Mathf.Min(_currentHeat, _maxHeat+1f);
            _particles.PlayIfStopped(_particles.OverHeatingParticle);
            _particles.OverHeatStartParticle.gameObject.SetActive(true); // Adjust clear option to "Disable"

        }
    }
}

