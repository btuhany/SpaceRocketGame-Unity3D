using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;
namespace UIs
{
    public class LevelCompletedScreen : MonoBehaviour
    {
        [SerializeField] private GameObject _levelCompletedPanel;
        private void Awake()
        {
           
            _levelCompletedPanel.SetActive(false);
        }
        private void OnEnable()
        {
            GameManager.Instance.OnLevelCompleted += HandleOnLevelCompleted;

        }
        private void OnDisable()
        {
            GameManager.Instance.OnLevelCompleted -= HandleOnLevelCompleted;
        }

        void HandleOnLevelCompleted()
        {
            _levelCompletedPanel.SetActive(true);
        }
    }

}
