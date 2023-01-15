using Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverheatUI : MonoBehaviour
{
    Slider _slider;
    OverheatMechanic _overheatLevel;

    public Slider Slider { get => _slider; set => _slider = value; }

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _overheatLevel = FindObjectOfType<OverheatMechanic>();
    }
    private void Start()
    {
        _slider.maxValue = _overheatLevel.MaxHeat;
    }
    private void Update()
    {
        _slider.value = _overheatLevel.CurrentHeat;
    }
}
