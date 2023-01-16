using Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryController : MonoBehaviour
{
    [SerializeField] float xMax;
    [SerializeField] float xMin;
    [SerializeField] float yMax;
    [SerializeField] float yMin;
    [SerializeField] float zMax;
    [SerializeField] float zMin;

    bool _outOfBoundaries=false;

    public bool OutOfBoundaries { get { return _outOfBoundaries; } set => _outOfBoundaries = value; }

    public bool IsInBoundary()
    {
        if (gameObject.transform.position.y < yMax && gameObject.transform.position.x<xMax && gameObject.transform.position.z<zMax)
        {
            if (gameObject.transform.position.y > yMin && gameObject.transform.position.x > xMin && gameObject.transform.position.z > zMin)
            {
                OutOfBoundaries = false;
                return true;
            }
        }
        
        return false; 
       
        

    }

    //Transform _objTransform;

    //public BoundaryController(Transform obj )
    //{
    //    _objTransform= obj;
    //}
    //OverheatMechanic _playerOverheat;
    //FuelMechanic _playerFuel;
    //bool _isOutOfTheBoundary;
    //private void OnTriggerExit(Collider other)
    //{


    //    _playerOverheat = other.gameObject.GetComponentInParent<OverheatMechanic>();
    //    _playerFuel = other.gameObject.GetComponentInParent<FuelMechanic>();
    //    if(_playerFuel!= null && _playerOverheat != null && (other.transform.position.y<this.gameObject.transform.position.y))
    //    {
    //        _isOutOfTheBoundary = true;
    //       // _playerOverheat.SetCurrentHeat(105);
    //    }
    //    else
    //        _isOutOfTheBoundary = false;

    //}

    //private void Update()
    //{
    //    if(!_isOutOfTheBoundary) { Debug.Log("ArtikSinirDisiDegil"); return; }
    //    _playerFuel.DecreaseFuel(3f);
    //    Debug.Log("SinirDiþi");
    //}
}
