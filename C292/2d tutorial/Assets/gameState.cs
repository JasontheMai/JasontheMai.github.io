using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gameState : MonoBehaviour
{
    bool _isGameOver = false;
    int _score = 0;
    [SerializeField] GameObject _scoreText;
    [SerializeField] GameObject _gameOverText;
    public static gameState Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Submit") && _isGameOver)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void IncreaseScore(int amount)
    {
        
        _score += amount;
        _scoreText.GetComponent<Text>().text = "Score: " + _score;
    }

    public void InitiateGameOver()
    {
        _isGameOver = true;
        _gameOverText.SetActive(true);
    }
}
