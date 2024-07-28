using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField] Text p1, p2,Win;
    [SerializeField] private GameObject PausePanel, GameOverPanel;
    private BallScript ball;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        GameOverPanel.SetActive(false);
        ball = GameObject.Find("Ball").GetComponent<BallScript>();
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
        GameOver();
    }
    private void GameOver()
    {
        
        if(p1.text == "5")
        {
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;
            Win.text = "PLAYER 2 WINS";  
            
        }
        else if (p2.text == "5")
        {
            GameOverPanel.SetActive(true);
            Time.timeScale = 0;
            Win.text = "PLAYER 1 WINS";
        }
    }
    private void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ResumeGame()
    {   
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void BacktoMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
