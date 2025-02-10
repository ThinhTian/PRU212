using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;
public class GameManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject gameWinUI;
    private bool isGameWin = false;
    private bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
        gameWinUI.SetActive(false);
        gameOverUI.SetActive(false);
    }

    public void AddScore(int points) {
        if (!isGameOver && !isGameWin) {
            score += points;
            UpdateScore();
        }
    }

    public void UpdateScore() {
        scoreText.text = score.ToString();
    }

    public void GameWin()
    {
        isGameWin = true;
        score = 0;
        Time.timeScale = 0;
        gameWinUI.SetActive(true);
    }

    public void GameOver()
    {
        isGameOver = true;
        score = 0;
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
    }

    public void RestartGame()
    {
        isGameOver=false;
        score = 0;
        UpdateScore();
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void MainMenu() 
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
    public bool IsGameOver() {
        return isGameOver;
    }
    public bool IsGameWin()
    {
        return isGameWin;
    }
}
