using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inputs;
namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float EnginePower = 2f;
        
        Rigidbody _rigidbody;
        DefaultInput _input;

        bool _isEngineUp;

        private void Awake()
        {
            _rigidbody= GetComponent<Rigidbody>();
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
                
                _rigidbody.AddForce(Vector3.up * Time.deltaTime * EnginePower);
            }
               
        }

    }

}
