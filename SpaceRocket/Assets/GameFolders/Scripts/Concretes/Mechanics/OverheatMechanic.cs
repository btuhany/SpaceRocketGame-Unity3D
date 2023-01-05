using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Mechanics 
{
    public class OverheatMechanic : MonoBehaviour
    {
        [SerializeField] float _maxHeat=100f;
        [SerializeField] float _currentHeat;
        [SerializeField] float _heatIncreaseSpeed;
        [SerializeField] float _heatDecreaseSpeed;
        [SerializeField] ParticleSystem _particle;

        public bool IsOverHeated => _currentHeat > _maxHeat-2f;
        

        public void HeatIncrease()
        {
            _currentHeat += _heatIncreaseSpeed;
            _currentHeat = Mathf.Min(_currentHeat, _maxHeat);
            if (_particle.isStopped) { _particle.Play(); }
        }

        public void HeatDecrease()
        {
            _currentHeat -= _heatDecreaseSpeed;
            _currentHeat = Mathf.Max(_currentHeat, 0f);

            if (_particle.isPlaying) { _particle.Stop(); }
        }
    }
}

