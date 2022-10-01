using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalSceneButtonsScript : MonoBehaviour
{
    public Text gameCompletedTextEng;
    public Text restartButtonTextEng;
    public Text quiteGametButtonTextEng;

    // Start is called before the first frame update
    void Start()
    {
        if (SettingsScript.GameLanguage == "English")
        {
            gameCompletedTextEng.text = PreferencesScript.GameCompletedTextEng;
            restartButtonTextEng.text = PreferencesScript.RestartButtonTextEng;
            quiteGametButtonTextEng.text = PreferencesScript.QuiteGametButtonTextEng;
        }
        else
        {
            gameCompletedTextEng.text = PreferencesScript.GameCompletedTextUkr;
            restartButtonTextEng.text = PreferencesScript.RestartButtonTextUkr;
            quiteGametButtonTextEng.text = PreferencesScript.QuiteGametButtonTextUkr;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
