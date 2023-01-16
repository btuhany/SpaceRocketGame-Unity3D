using Managers;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

namespace Mechanics
{
    public class FuelMechanic : MonoBehaviour
    {
        [SerializeField] private float _totalFuel;
        [SerializeField] float _fuelDecreaseSpeed;
        [SerializeField] float _fuelDecreaseSpeedOutOfBoundaries;
        public bool IsFuelRanOut => _totalFuel == 0;

        public float TotalFuel { get => _totalFuel; set => _totalFuel = value; }

        public void DecreaseFuel(float speed = 1f)
        {
            _totalFuel = _totalFuel - _fuelDecreaseSpeed*speed;
            
            _totalFuel = Mathf.Max(_totalFuel, 0f);
            FuelControl();
            

        }
        private void FuelControl()
        {
            if (_totalFuel == 0f)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

