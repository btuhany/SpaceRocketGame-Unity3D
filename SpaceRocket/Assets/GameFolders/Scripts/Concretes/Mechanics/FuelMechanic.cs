using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mechanics
{
    public class FuelMechanic : MonoBehaviour
    {
        [SerializeField] private float _totalFuel;
        [SerializeField] float _fuelDecreaseSpeed;
        float _fuelAlertSoundLimit;
        //[SerializeField] float _fuelDecreaseSpeedOutOfBoundaries;
        public bool IsFuelRanOut => _totalFuel == 0;

        public float TotalFuel { get => _totalFuel; set => _totalFuel = value; }
        private void Start()
        {
            _fuelAlertSoundLimit = _totalFuel * 0.2f;
        }

        public void DecreaseFuel(float speed = 1f)
        {
            _totalFuel = _totalFuel - _fuelDecreaseSpeed * speed;

            _totalFuel = Mathf.Max(_totalFuel, 0f);
            FuelControl();
            

        }
        private void FuelControl()
        {
            if (_totalFuel == 0f)
            {
                GameManager.Instance.GameOver();
            }
            else if (_totalFuel < _fuelAlertSoundLimit)
            {
                SoundManager.Instance.PlaySound(7);
            }
            else
            {
                SoundManager.Instance.StopSound(7, 1f);
            }
        }
    }
}


