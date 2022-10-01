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
    public Text StartButtonText;

    float timeLeft = SettingsScript.LevelHardness;
    bool TimerStarted = false;
    public int NeededItemsNumber = 5;
    public SC_InventorySystem sc_InventorySystem;

    public Text infoText;

    //pause panel
    public Text pauseText;
    public Text resumeText;
    public Text quitText;

    //out panel
    public Text yesButtonOutText;
    public Text noButtonOutText;

    // Start is called before the first frame update
    void Start()
    {
        PauseGame();

        if (SettingsScript.GameLanguage == "English")
        {
            switch (SceneManager.GetActiveScene().name)
            {
                case "PetEmergencyKitScene":
                    infoText.text = PreferencesScript.TaskForTheLevelEng;
                    break;
                case "ClothesKitScene":
                    infoText.text = PreferencesScript.TaskForTheClothesLevelEng;
                    break;
                case "FoodKitScene":
                    infoText.text = PreferencesScript.TaskForTheFoodLevelEng;
                    break;
                case "HeavyMedicalKitScene":
                    infoText.text = PreferencesScript.TaskForTheHeavyMedicalLevelEng;
                    break;
                case "LightMedicalKitScene":
                    infoText.text = PreferencesScript.TaskForTheLigthMedicalLevelEng;
                    break;
                case "EmergencyBagKitScene":
                    infoText.text = PreferencesScript.TaskForTheEmergencyLevelEng;
                    break;
                default:
                    infoText.text = "Please, collect 5 valuable items. Are you ready?";
                    break;
            }

            StartButtonText.text = PreferencesScript.StartButtonTextEng;

            //pause panel
            pauseText.text = PreferencesScript.PauseTextEng;
            resumeText.text = PreferencesScript.ResumeTextEng;
            quitText.text = PreferencesScript.QuitButtonTextEng;

            //out panel
            yesButtonOutText.text = PreferencesScript.YesButtonOutTextEng;
            noButtonOutText.text = PreferencesScript.NoButtonOutTextEng;
        }
        else
        {
            switch (SceneManager.GetActiveScene().name)
            {
                case "PetEmergencyKitScene":
                    infoText.text = PreferencesScript.TaskForTheLevelUkr;
                    break;
                case "ClothesKitScene":
                    infoText.text = PreferencesScript.TaskForTheClothesLevelUkr;
                    break;
                case "FoodKitScene":
                    infoText.text = PreferencesScript.TaskForTheFoodLevelUkr;
                    break;
                case "HeavyMedicalKitScene":
                    infoText.text = PreferencesScript.TaskForTheHeavyMedicalLevelUkr;
                    break;
                case "LightMedicalKitScene":
                    infoText.text = PreferencesScript.TaskForTheLigthMedicalLevelUkr;
                    break;
                case "EmergencyBagKitScene":
                    infoText.text = PreferencesScript.TaskForTheEmergencyLevelUkr;
                    break;
                default:
                    infoText.text = "Please, collect 5 valuable items. Are you ready?";
                    break;
            }

            StartButtonText.text = PreferencesScript.StartButtonTextUkr;
            
            //pause panel
            pauseText.text = PreferencesScript.PauseTextUkr;
            resumeText.text = PreferencesScript.ResumeTextUkr;
            quitText.text = PreferencesScript.QuitButtonTextUkr;

            //out panel
            yesButtonOutText.text = PreferencesScript.YesButtonOutTextUkr;
            noButtonOutText.text = PreferencesScript.NoButtonOutTextUkr;
        }
        
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

        if (SettingsScript.GameLanguage == "English")
        {
            infoText.text = PreferencesScript.FailureTextEng;
        }
        else
        {
            infoText.text = PreferencesScript.FailureTextUkr;
        }
    }

    void GameWin()
    {
        infoText.color = Color.green;

        if (SettingsScript.GameLanguage == "English")
        {
            infoText.text = PreferencesScript.WinTextEng;
        }
        else
        {
            infoText.text = PreferencesScript.WinTextUkr;
        }
        
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        text.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
