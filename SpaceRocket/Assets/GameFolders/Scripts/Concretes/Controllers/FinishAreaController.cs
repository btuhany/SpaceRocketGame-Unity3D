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

            if (_player == null) return;

                Rigidbody _playerRb = _player.GetComponent<Rigidbody>();
                _playerRb.constraints = RigidbodyConstraints.FreezeAll;

                _finishFireWorks.gameObject.SetActive(true);

                
                


            if (collision.GetContact(0).normal.y<-0.75)
            {
                Debug.Log("Degdi");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}

