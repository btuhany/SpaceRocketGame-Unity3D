using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputs;
using Movements;
using Mechanics;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _enginePower = 2f;
        [SerializeField] float _rotateSpeed;
        [SerializeField] float _engineRotatePower;

        DefaultInput _input;
        Mover _mover;
        Rotator _rotator;
        OverheatMechanic _overheat;

        bool _isEngineOn;
        float _rotateLeftRight;
        float _rotateFrontBack;
        private void Awake()
        {
            _mover = new Mover(GetComponent<Rigidbody>());
            _rotator = new Rotator(gameObject);
            _input = new DefaultInput();
            _overheat = GetComponent<OverheatMechanic>();
        }
        private void Update()
        {
            if (_input.IsEngineUp && !_overheat.IsOverHeated)
            {
                _isEngineOn = true;
                
            }
            else
            {
                _isEngineOn = false;
                
            }
                
            _rotateLeftRight = _input.RotateLeftRight;
            _rotateFrontBack = _input.RotateFrontBack;
        }
        private void FixedUpdate()
        {
            if(_isEngineOn)
            {
                _mover.RelativeForceUp(_enginePower);
                _overheat.HeatIncrease();
            }
            else
            {
                _overheat.HeatDecrease();
            }

                _rotator.RotateZ(_rotateLeftRight, _rotateSpeed);
                _mover.ForceUpIfRotates(_rotateLeftRight, _engineRotatePower);
                _rotator.RotateX(_rotateFrontBack, _rotateSpeed);
                _mover.ForceUpIfRotates(_rotateFrontBack, _engineRotatePower);

        }

    }

}
