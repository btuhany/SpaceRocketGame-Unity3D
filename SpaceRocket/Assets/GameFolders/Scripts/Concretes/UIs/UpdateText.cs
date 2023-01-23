using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UIs;
namespace UIs
{
    public class UpdateText : MonoBehaviour
    {
       FuelUI _fuelSlider;
        OverheatUI _overheatSlider;
        private void Awake()
        {
            _fuelSlider = GetComponentInParent<FuelUI>();
            _overheatSlider = GetComponentInParent<OverheatUI>();
        }
        public void FuelTextUpdate(float value)
        {
            
            TextMeshProUGUI _fuelPercentLabel = GetComponent<TextMeshProUGUI>(); 
            if (_fuelPercentLabel != null)
            {
                if (value / _fuelSlider.Slider.maxValue * 100 <= 20)
                    _fuelPercentLabel.faceColor = Color.red;
                _fuelPercentLabel.SetText(Mathf.RoundToInt(value / _fuelSlider.Slider.maxValue * 100).ToString());
                
            }
                //_fuelPercentLabel = Mathf.RoundToInt(value * 100) + "%";
        }
        public void OverheatTextUpdate(float value)
        {

            TextMeshProUGUI _overheatPercentLabel = GetComponent<TextMeshProUGUI>();
            if (_overheatPercentLabel != null)
            {
                _overheatPercentLabel.SetText(Mathf.RoundToInt(value / _overheatSlider.Slider.maxValue * 100).ToString());
            }
            //_fuelPercentLabel = Mathf.RoundToInt(value * 100) + "%";
        }


    }
}

