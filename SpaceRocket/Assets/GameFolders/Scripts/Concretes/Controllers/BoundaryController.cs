using Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    OverheatMechanic _playerOverheat;
    FuelMechanic _playerFuel;
    bool _isOutOfTheBoundary;
    private void OnTriggerEnter(Collider other)
    {
        _isOutOfTheBoundary= true;
        _playerOverheat = other.gameObject.GetComponentInParent<OverheatMechanic>();
        _playerFuel = other.gameObject.GetComponentInParent<FuelMechanic>();
        _playerOverheat.SetCurrentHeat(105);
    }

    private void Update()
    {
        if(!_isOutOfTheBoundary) { return; }
        _playerFuel.DecreaseFuel(5f);
    }
}
