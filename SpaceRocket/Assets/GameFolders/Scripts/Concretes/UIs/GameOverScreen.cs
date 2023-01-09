using Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;

    private void Awake()
    {
        _gameOverPanel.SetActive(false);
    }
    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += HandleOnGameOver;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= HandleOnGameOver;
    }
    void HandleOnGameOver()
    {
        _gameOverPanel.SetActive(true);
    }
}
