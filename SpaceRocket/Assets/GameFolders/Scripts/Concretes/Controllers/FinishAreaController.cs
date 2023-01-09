using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class FinishAreaController : MonoBehaviour
    {
        [SerializeField] ParticleSystem _finishFireWorks;

        private void OnCollisionEnter(Collision collision)
        {
            PlayerController _player = collision.gameObject.GetComponent<PlayerController>();

            if (_player == null || !_player.CanMove) return;

               _finishFireWorks.gameObject.SetActive(true);
                GameManager.Instance.LevelCompleted();

                
                


            if (collision.GetContact(0).normal.y<-0.75)
            {
                Debug.Log("Degdi");
            }
            else
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

