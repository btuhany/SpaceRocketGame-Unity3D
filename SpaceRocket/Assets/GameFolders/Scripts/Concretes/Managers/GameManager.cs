using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        //Singleton Pattern
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
    }

}
