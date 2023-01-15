using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mechanics;
namespace UIs
{
    public class FuelUI : MonoBehaviour
    {
        Slider _slider;
        FuelMechanic _fuelMechanic;

        public Slider Slider { get => _slider; set => _slider = value; }

        private void Awake()
        {
            _slider= GetComponent<Slider>();
            _fuelMechanic = FindObjectOfType<FuelMechanic>();
        }
        private void Start()
        {
            _slider.maxValue = _fuelMechanic.TotalFuel;
        }
        private void Update()
        {
            _slider.value = _fuelMechanic.TotalFuel;
        }
    }

}
