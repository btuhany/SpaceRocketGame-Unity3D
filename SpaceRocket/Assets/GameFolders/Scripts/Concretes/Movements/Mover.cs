using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Movements
{
    public class Mover
    {
        Rigidbody _rigidbody;
        
       public Mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

       public void RelativeForceUp(float Force)
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * Force);
        }
    }
}

