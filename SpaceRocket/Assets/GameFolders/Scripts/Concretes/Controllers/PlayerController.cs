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
        
        
        DefaultInput _input;
        Mover _mover;

        bool _isEngineUp;

        private void Awake()
        {
            _mover = new Mover(GetComponent<Rigidbody>());
            _input = new DefaultInput();
        }
        private void Update()
        {
            if (_input.IsEngineUp)
                _isEngineUp = true;
            else
                _isEngineUp = false;
        }
        private void FixedUpdate()
        {
            if(_isEngineUp)
            {
                _mover.RelativeForceUp(EnginePower);
                
            }
               
        }

    }

}
