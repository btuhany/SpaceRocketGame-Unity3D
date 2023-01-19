using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateLevelText : MonoBehaviour
{
    TextMeshProUGUI _levelText;
    private void Awake()
    {
        _levelText = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        _levelText.SetText("LEVEL " + (SceneManager.sceneCountInBuildSettings-1));
    }
}
