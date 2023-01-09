using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIs
{
    public class LevelCompletedPanel : MonoBehaviour
    {
        public void NextClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        public void QuitClick()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}

