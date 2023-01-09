using Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class WallManager : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            PlayerController player= collision.gameObject.GetComponent<PlayerController>();

            
            if(player!=null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

