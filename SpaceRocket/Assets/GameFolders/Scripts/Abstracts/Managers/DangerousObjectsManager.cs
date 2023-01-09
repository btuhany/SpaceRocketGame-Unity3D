using Controllers;
using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Abstracts.Managers
{
    public abstract class DangerousObjectsManager : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player = collision.gameObject.GetComponent<PlayerController>();


            if (player != null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }

}
