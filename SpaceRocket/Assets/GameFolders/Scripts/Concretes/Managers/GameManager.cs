using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class GameManager : SingletonObject<GameManager>
    {
        public event System.Action OnGameOver;  //we created an action that will contain the functions must be used on game over

        public event System.Action OnLevelCompleted;


        private void Awake()
        {
            SingletonThisGameObject(this);
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
            //if (levelIndex == 0)
            //{
            //    StartCamera.Instance.IsCameraTransitionFinished= true;
            //}
        }


        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());

        }
        IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }
        public void Exit()
        {
            Debug.Log("Exit");
            Application.Quit();
        }
    }

}
