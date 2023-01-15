using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

namespace Mechanics
{
    public class FuelMechanic : MonoBehaviour
    {
        [SerializeField] public float _totalFuel;
        [SerializeField] float _fuelDecreaseSpeed;
        public bool IsFuelRanOut => _totalFuel == 0;
        public void DecreaseFuel()
        {
            _totalFuel = _totalFuel - _fuelDecreaseSpeed;
            _totalFuel = Mathf.Max(_totalFuel, 0f);
        }
    }
}

