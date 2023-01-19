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
        [SerializeField] float _fuelDecreaseSpeedOutside;


        DefaultInput _input;
        Mover _mover;
        Rotator _rotator;
        OverheatMechanic _overheat;
        RocketParticles _particles;
        Rigidbody _rb;
        FuelMechanic _fuel;
        BoundaryController _boundary;

        bool _canMove;
        bool _isEngineOn;
        float _rotateLeftRight;
        float _rotateFrontBack;

        public bool CanMove
        {
            get
            {
                return _canMove;
            }
            set
            {
                _canMove = value;
            }
        }

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _mover = new Mover(_rb);
            _rotator = new Rotator(gameObject);
            _input = new DefaultInput();
            _overheat = GetComponent<OverheatMechanic>();
            _particles = GetComponent<RocketParticles>();
            _fuel = GetComponent<FuelMechanic>();
            _boundary = GetComponent<BoundaryController>();
        }
        private void Start()
        {
            _canMove = true;
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventGameOver;
            GameManager.Instance.OnLevelCompleted += HandleOnEventLevelCompleted;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventGameOver;
            GameManager.Instance.OnLevelCompleted -= HandleOnEventLevelCompleted;
        }
        private void Update()
        {
            if (!_canMove) return;
            if(!_boundary.IsInBoundary())
            {
                Debug.Log("Outside");
                _fuel.DecreaseFuel(_fuelDecreaseSpeedOutside);
                if (!_boundary.OutOfBoundaries)
                {
                    _overheat.SetCurrentHeat(104);    
                    _boundary.OutOfBoundaries = true; // should have done it with event
                }

            }
            if (_input.Restart)
            {
                GameManager.Instance.LoadLevelScene(0);
            }
            if (_input.IsEngineUp && _overheat.IsOverHeated)
            {
                _isEngineOn = false;
                _overheat.OverHeating();
                _particles.StopIfPlaying(_particles.FireUpParticle);
                Debug.Log("EngineUp,Overheat");

            }
            else if (_input.IsEngineUp && !_overheat.IsOverHeated ) /*&& !_fuel.IsFuelRanOut*/
            {
                _isEngineOn = true;
                _overheat.HeatIncrease();
                _particles.PlayIfStopped(_particles.FireUpParticle);
                _fuel.DecreaseFuel();
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
            if (_isEngineOn )  /*&& !_fuel.IsFuelRanOut*/
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
            ResetandStop();
            _particles.GameOverParticle.gameObject.SetActive(true);
        }
        /// <summary>
        /// Birleþtirilebilir
        /// </summary>
        private void HandleOnEventLevelCompleted()
        {
            _rb.constraints = RigidbodyConstraints.FreezeAll;
            ResetandStop();

        }

        private void ResetandStop()
        {
            _canMove = false;
            _isEngineOn = false;
            _rotateLeftRight = 0f;
            _rotateFrontBack = 0f;
            _particles.StopIfPlaying(_particles.FireUpParticle);
            
        }


    }

}
