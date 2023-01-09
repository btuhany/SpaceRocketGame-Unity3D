using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesClick()
        {
            GameManager.Instance.LoadLevelScene(0);
        }
        public void NoClick()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}

