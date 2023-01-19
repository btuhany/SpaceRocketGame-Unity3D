using Abstracts.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Managers
{
    public class AsteroidsManager : DangerousObjectsManager
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed = 1f;
        [SerializeField] float _torqueForce = 1f;
        float _factor;
        Rigidbody _rb;
        Vector3 _startPosition;
        
        private void Awake()
        {
            _startPosition= transform.position;
            _rb= GetComponent<Rigidbody>();
        }
        private void Start()
        {
            _rb.AddTorque((Vector3.forward + Vector3.right)*_torqueForce);
        }
        private void Update()
        {
            //sin(2*pi*T*speed) 
            float sinWave= Mathf.Sin(Mathf.PI*2*Time.time*_speed);
            _factor = sinWave;
            Vector3 offset= _direction * _factor;
            transform.position = offset + _startPosition;

            

        }
    }

}
