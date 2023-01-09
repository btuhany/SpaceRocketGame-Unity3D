using Abstracts.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Managers
{
    public class AsteroidsManager : DangerousObjectsManager
    {
        [SerializeField] Vector3 _direction;
        [Range(0f, 2f)][SerializeField] float _factor;

        Vector3 _startPosition;
        private void Awake()
        {
            _startPosition= transform.position;
        }

        private void Update()
        {
            Vector3 offset= _direction * _factor;
            transform.position = offset + _startPosition;

      

        }
    }

}
