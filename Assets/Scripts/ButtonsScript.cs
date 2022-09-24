using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject outPanel;
    public GameObject pausePanel;
    public Text text;
    public Text infoText;
    public string TaskForTheLevel = "Please, collect 5 valuable items.Are you ready?";
    float timeLeft = SettingsScript.LevelHardness;
    bool TimerStarted = false;
    public int NeededItemsNumber = 5;
    public SC_InventorySystem sc_InventorySystem;
    // Start is called before the first frame update
    void Start()
    {
        PauseGame();
        infoText.text = TaskForTheLevel;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerStarted)
        {
            
            if (timeLeft < 0 )
            {
                if (sc_InventorySystem.CollectedItemsCount < NeededItemsNumber)
                {
                    GameOver();
                }
                else
                {
                    GameWin();
                }

                DisplayTime(0);

            }
            else
            {
                DisplayTime(timeLeft);
                timeLeft -= Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.Escape))
            {
                PauseInGameGame();
            }

        }
        
    }

    public void StartGame()
    {
        Destroy(startPanel);
        Cursor.visible = false;  //collected items list initiate
        Cursor.lockState = CursorLockMode.Locked;
        ResumeGame();

        infoText.text = string.Empty;

        TimerStarted = true;

    }

    public void OutScene()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    public void CancelOutScene()
    {
        outPanel.SetActive(false);
        Cursor.visible = false;  //collected items list initiate
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    public void ResumePauseInGameGame()
    {
        Time.timeScale = 1;
        Cursor.visible = false;  //collected items list initiate
        Cursor.lockState = CursorLockMode.Locked;
        pausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void PauseInGameGame()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        pausePanel.SetActive(true);
    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
    }

    void GameOver()
    {
        Time.timeScale = 0;
        infoText.color = Color.red;
        infoText.text = "Game Over... ";
    }

    void GameWin()
    {
        infoText.color = Color.green;
        infoText.text = "You win! ";
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
