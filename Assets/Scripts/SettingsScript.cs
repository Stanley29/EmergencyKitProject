using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject startPanel;
    public static float LevelHardness = 30;
    public static string GameLanguage = "English";

    //hardness level texts
    public Text currentLevelText;
    public Text easyGameLevelButtonText;
    public Text middleGameLevelButtonText;
    public Text hardGameLevelButtonText;
    public Text chooseYourHardnessLevel;

    //main menu texts
    public Text startButtonText;
    public Text quitButtonText;
    public Text settingsButtonText;


    // Start is called before the first frame update
    void Start()
    {
        currentLevelText.text = PreferencesScript.EasyGameLevelEng;

        chooseYourHardnessLevel.text = PreferencesScript.ChooseYourHardnessLevelEng;
        easyGameLevelButtonText.text = PreferencesScript.EasyGameLevelEng;
        middleGameLevelButtonText.text = PreferencesScript.MiddleGameLevelEng;
        hardGameLevelButtonText.text = PreferencesScript.HardGameLevelEng;

        startButtonText.text = PreferencesScript.StartButtonTextEng;
        quitButtonText.text = PreferencesScript.QuitButtonTextEng;
        settingsButtonText.text = PreferencesScript.SettingsButtonTextEng;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EasyLevelButton()
    {
        LevelHardness = 30;
        settingsPanel.SetActive(false);

        if (GameLanguage == "English")
        {
            currentLevelText.text = PreferencesScript.EasyGameLevelEng;
        }
        else
        {
            currentLevelText.text = PreferencesScript.EasyGameLevelUkr;
        }
    }

    public void MiddleLevelButton()
    {
        LevelHardness = 20;
        settingsPanel.SetActive(false);

        if (GameLanguage == "English")
        {
            currentLevelText.text = PreferencesScript.MiddleGameLevelEng;
        }
        else
        {
            currentLevelText.text = PreferencesScript.MiddleGameLevelUkr;
        }
    }

    public void HardLevelButton()
    {
        LevelHardness = 10;
        settingsPanel.SetActive(false);

        if (GameLanguage == "English")
        {
            currentLevelText.text = PreferencesScript.HardGameLevelEng;
        }
        else
        {
            currentLevelText.text = PreferencesScript.HardGameLevelUkr;
        }
    }

    public void SettingsButton()
    {
        settingsPanel.SetActive(true);
    }

    public void SetEnglish()
    {
        GameLanguage = "English";

        switch (LevelHardness)
        {
            case 10:
                currentLevelText.text = PreferencesScript.HardGameLevelEng;
                break;
            case 20:
                currentLevelText.text = PreferencesScript.MiddleGameLevelEng;
                break;
            case 30:
                currentLevelText.text = PreferencesScript.EasyGameLevelEng;
                break;
            default:
                break;
        }

        chooseYourHardnessLevel.text = PreferencesScript.ChooseYourHardnessLevelEng;
        easyGameLevelButtonText.text = PreferencesScript.EasyGameLevelEng;
        middleGameLevelButtonText.text = PreferencesScript.MiddleGameLevelEng;
        hardGameLevelButtonText.text = PreferencesScript.HardGameLevelEng;

        startButtonText.text = PreferencesScript.StartButtonTextEng;
        quitButtonText.text = PreferencesScript.QuitButtonTextEng;
        settingsButtonText.text = PreferencesScript.SettingsButtonTextEng;
    }

    public void SetUkrainian()
    {
        GameLanguage = "Ukrainian";

        switch (LevelHardness)
        {
            case 10:
                currentLevelText.text = PreferencesScript.HardGameLevelUkr;
                break;
            case 20:
                currentLevelText.text = PreferencesScript.MiddleGameLevelUkr;
                break;
            case 30:
                currentLevelText.text = PreferencesScript.EasyGameLevelUkr;
                break;
            default:
                break;
        }

        chooseYourHardnessLevel.text = PreferencesScript.ChooseYourHardnessLevelUkr;
        easyGameLevelButtonText.text = PreferencesScript.EasyGameLevelUkr;
        middleGameLevelButtonText.text = PreferencesScript.MiddleGameLevelUkr;
        hardGameLevelButtonText.text = PreferencesScript.HardGameLevelUkr;

        startButtonText.text = PreferencesScript.StartButtonTextUkr;
        quitButtonText.text = PreferencesScript.QuitButtonTextUkr;
        settingsButtonText.text = PreferencesScript.SettingsButtonTextUkr;
    }
}
