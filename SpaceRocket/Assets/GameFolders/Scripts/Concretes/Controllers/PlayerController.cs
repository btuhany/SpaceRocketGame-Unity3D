using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputs;
using Movements;
using Mechanics;
using Particles;
using Managers;

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
        RocketParticles _particles;

        bool _canMove;
        bool _isEngineOn;
        float _rotateLeftRight;
        float _rotateFrontBack;
        private void Awake()
        {
            _mover = new Mover(GetComponent<Rigidbody>());
            _rotator = new Rotator(gameObject);
            _input = new DefaultInput();
            _overheat = GetComponent<OverheatMechanic>();
            _particles = GetComponent<RocketParticles>();
        }
        private void Start()
        {
            _canMove = true;
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventGameOver;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventGameOver;
        }
        private void Update()
        {
            if (!_canMove) return;
            if (_input.IsEngineUp && _overheat.IsOverHeated)
            {
                _isEngineOn = false;
                _overheat.OverHeating();
                _particles.StopIfPlaying(_particles.FireUpParticle);
                Debug.Log("EngineUp,Overheat");

            }
            else if (_input.IsEngineUp && !_overheat.IsOverHeated)
            {
                _isEngineOn = true;
                _overheat.HeatIncrease();
                _particles.PlayIfStopped(_particles.FireUpParticle);
                Debug.Log("EngineUp,HeatIncreases");
            }
            else
            {
                _isEngineOn = false;
                _overheat.HeatDecrease();
                _particles.StopIfPlaying(_particles.FireUpParticle);
                Debug.Log("EngineDown,HeatDecreases");

            }
                
            _rotateLeftRight = _input.RotateLeftRight;
            _rotateFrontBack = _input.RotateFrontBack;
        }
        private void FixedUpdate()
        {
            if(_isEngineOn)
            {
                _mover.RelativeForceUp(_enginePower);
                
                
            }
                _rotator.RotateZ(_rotateLeftRight, _rotateSpeed);
                _mover.ForceUpIfRotates(_rotateLeftRight, _engineRotatePower);
                _rotator.RotateX(_rotateFrontBack, _rotateSpeed);
                _mover.ForceUpIfRotates(_rotateFrontBack, _engineRotatePower);

        }
        private void HandleOnEventGameOver()
        {
            _canMove= false;
            _isEngineOn= false;
            _rotateLeftRight = 0f;
            _rotateFrontBack = 0f;  
            _overheat.SetCurrentHeat(0);

        }

    }

}
