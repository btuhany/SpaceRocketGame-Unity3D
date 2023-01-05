using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputs;
using Movements;
namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float EnginePower = 2f;
        [SerializeField] float RotateSpeed;
        [SerializeField] float EnginePowerWhenRotating;

        DefaultInput _input;
        Mover _mover;
        Rotator _rotator;

        bool _isEngineOn;
        float _rotateLeftRight;
        float _rotateFrontBack;
        private void Awake()
        {
            _mover = new Mover(GetComponent<Rigidbody>());
            _rotator = new Rotator(gameObject);
            _input = new DefaultInput();
        }
        private void Update()
        {
            if (_input.IsEngineUp)
                _isEngineOn = true;
            else
                _isEngineOn = false;
            _rotateLeftRight = _input.RotateLeftRight;
            _rotateFrontBack = _input.RotateFrontBack;
        }
        private void FixedUpdate()
        {
            if(_isEngineOn)
            {
                _mover.RelativeForceUp(EnginePower);     
            }

                _rotator.RotateZ(_rotateLeftRight, RotateSpeed);
                _mover.ForceUpIfRotates(_rotateLeftRight, EnginePowerWhenRotating);
                _rotator.RotateX(_rotateFrontBack, RotateSpeed);
                _mover.ForceUpIfRotates(_rotateFrontBack, EnginePowerWhenRotating);

        }

    }

}
