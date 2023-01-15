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
        private void Awake()
        {
            _slider= GetComponent<Slider>();
            _fuelMechanic = FindObjectOfType<FuelMechanic>();
        }
        private void Update()
        {
            _slider.value = _fuelMechanic._totalFuel;
        }
    }

}
