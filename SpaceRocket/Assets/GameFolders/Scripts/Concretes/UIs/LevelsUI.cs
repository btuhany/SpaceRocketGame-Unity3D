using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class LevelsUI : MonoBehaviour
    {
        [SerializeField] GameObject _levelsPanel;

        public void ChangeStatusOfLevelsPanel()
        {
            if(_levelsPanel.activeSelf)
            _levelsPanel.SetActive(false);
            else
                _levelsPanel.SetActive(true);
        }
        public void LoadLevel1()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        public void LoadLevel2()
        {
            GameManager.Instance.LoadLevelScene(2);
        }
        public void LoadLevel3()
        {
            GameManager.Instance.LoadLevelScene(3);
        }
        public void LoadLevel4()
        {
            GameManager.Instance.LoadLevelScene(4);
        }
        public void LoadLevel5()
        {
            GameManager.Instance.LoadLevelScene(5);
        }
        public void LoadLevel6()
        {
            GameManager.Instance.LoadLevelScene(6);
        }
        public void LoadLevel7()
        {
            GameManager.Instance.LoadLevelScene(7);
        }
        public void LoadLevel8()
        {
            GameManager.Instance.LoadLevelScene(8);
        }
    }

}
