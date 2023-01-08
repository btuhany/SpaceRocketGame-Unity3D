using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;  //we created an action that will contain the functions must be used on game over
        public static GameManager Instance { get; private set; } //statics are single

        private void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
            SingletonThisGameObject();
        }
        private void SingletonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void GameOver()
        {
            if (OnGameOver != null)
            {
                OnGameOver.Invoke();
            }
            //OnGameOver?.Invoke();
        }
    }

}
