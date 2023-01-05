using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Movements
{
    public class Rotator
    {
        Rigidbody _rigidbody;
        GameObject _gameObject;

        public Rotator(GameObject gameObject)
        {
            _gameObject = gameObject;
            _rigidbody= gameObject.GetComponent<Rigidbody>();
        }

        public void RotateZ(float RotateDirection, float Force)
        {
            //ControlRotation(RotateDirection);
            //_gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * RotateDirection * Force);
            _rigidbody.AddRelativeTorque(Vector3.forward * Time.deltaTime * RotateDirection * Force);
           
        }
        public void RotateX(float RotateDirection, float Force)
        {
            //ControlRotation(RotateDirection);
            // _gameObject.transform.Rotate(Vector3.right * Time.deltaTime * RotateDirection * Force);
            _rigidbody.AddRelativeTorque(Vector3.right * Time.deltaTime * RotateDirection * Force);
           
            

        }


        void ControlRotation(float rotatedirection)
        {
            if(rotatedirection== 0)
            {
                _rigidbody.freezeRotation = true;
            }
            else
           {
                _rigidbody.freezeRotation = false;
               
            }

        }

        void ControlRotate()
        {
           
        }
    }

}
