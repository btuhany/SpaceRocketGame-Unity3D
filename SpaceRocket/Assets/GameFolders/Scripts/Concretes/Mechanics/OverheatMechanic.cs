using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Particles;
using Managers;

namespace Mechanics 
{
    public class OverheatMechanic : MonoBehaviour
    {
        [SerializeField] float _maxHeat=100f;
        [SerializeField] float _currentHeat;
        [SerializeField] float _heatIncreaseSpeed;
        [SerializeField] float _heatDecreaseSpeed;

        bool _isOverheatStartedAlready;
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

        public float MaxHeat { get => _maxHeat; set => _maxHeat = value; }
        public float CurrentHeat { get => _currentHeat; set => _currentHeat = value; }

        public void HeatIncrease()
        {
            
            _currentHeat += _heatIncreaseSpeed*Time.deltaTime;
            _isOverheatStartedAlready = false;
            
        }

        public void HeatDecrease()
        {
            _currentHeat -= _heatDecreaseSpeed * Time.deltaTime;
            _currentHeat = Mathf.Max(_currentHeat, 0f);
        }

        public void OverHeating()
        {
            if (!_isOverheatStartedAlready)
            {
                _particles.OverHeatStartParticle.gameObject.SetActive(true);
                SoundManager.Instance.PlaySound(5);
                _isOverheatStartedAlready = true;
            }

            _currentHeat += _heatIncreaseSpeed*1.2f;
            _currentHeat = Mathf.Min(_currentHeat, _maxHeat+1f);
            _particles.PlayIfStopped(_particles.OverHeatingParticle);  //Maybe SetActive also can be used.
           

        }
        public void SetCurrentHeat(float heat)
        {
            _currentHeat = heat;
            if(heat>_maxHeat)
            {
                _particles.OverHeatStartParticle.gameObject.SetActive(true);
                SoundManager.Instance.PlaySound(5);
            }
        }

    }
}

