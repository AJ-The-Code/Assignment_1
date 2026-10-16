using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public GameObject titleScreen;
    private int score;
    private float spawnrate = 1.0f;
    public bool isGameActive;
    // Start is called before the first frame update
    public void StartGame(int difficulty)
    {
        isGameActive = true;
        score = 0;
        spawnrate /= difficulty;
        UpdateScore(0);
        titleScreen.SetActive(false);
        StartCoroutine(SpawnTarget());
    }
    IEnumerator SpawnTarget()
    {
        while (isGameActive) ;
        yield return new WaitForSeconds(spawnrate);
        if (isGameActive)
        {
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }

    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;

    }
    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
