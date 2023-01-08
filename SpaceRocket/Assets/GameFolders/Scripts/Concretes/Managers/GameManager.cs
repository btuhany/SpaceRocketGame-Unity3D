using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;  //we created an action that will contain the functions must be used on game over

        public event System.Action OnLevelCompleted;
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
            //if (OnGameOver != null)
            //{
            //    OnGameOver.Invoke();
            //}
            OnGameOver?.Invoke();

        }
        public void LevelCompleted()
        {
            //if (OnGameOver != null)
            //{
            //    OnGameOver.Invoke();
            //}
            OnLevelCompleted?.Invoke();
        }
        public void LoadLevelScene(int levelIndex=0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));            
        }
        IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);
        }


        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());

        }
        IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }
        void Exit()
        {
            Debug.Log("Exit");
            Application.Quit();
        }
    }

}
