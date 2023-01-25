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
        private void Start()
        {
            SoundManager.Instance.PlaySound(1);
        }


        public void GameOver()
        {
            //if (OnGameOver != null)
            //{
            //    OnGameOver.Invoke();
            //}

            OnGameOver?.Invoke();
            SoundManager.Instance.StopAllSounds();
            SoundManager.Instance.PlaySound(4);


        }
        public void LevelCompleted()
        {
            //if (OnGameOver != null)
            //{
            //    OnGameOver.Invoke();
            //}
            OnLevelCompleted?.Invoke();
            SoundManager.Instance.StopAllSounds();
            SoundManager.Instance.PlaySound(3);
        }
        public void LoadLevelScene(int levelIndex=0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
            SoundManager.Instance.StopAllSounds();
            SoundManager.Instance.PlaySound(2);
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
            SoundManager.Instance.StopAllSounds();
            SoundManager.Instance.PlaySound(1);

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
