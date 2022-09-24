using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject startPanel;
    public Text CurrentLevelText;
    public static float LevelHardness = 30;
    // Start is called before the first frame update
    void Start()
    {
        CurrentLevelText.text = "Easy";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EasyLevelButton()
    {
        LevelHardness = 30;
        settingsPanel.SetActive(false);
        CurrentLevelText.text = "Easy";
    }

    public void MiddleLevelButton()
    {
        LevelHardness = 20;
        settingsPanel.SetActive(false);
        CurrentLevelText.text = "Middle";
    }

    public void HardLevelButton()
    {
        LevelHardness = 10;
        settingsPanel.SetActive(false);
        CurrentLevelText.text = "Hard";
    }

    public void SettingsButton()
    {
        settingsPanel.SetActive(true);
    }
}
