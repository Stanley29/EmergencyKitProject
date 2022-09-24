using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject startPanel;
    public static float LevelHardness = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EasyLevelButton()
    {
        LevelHardness = 30;
        settingsPanel.SetActive(false);
        startPanel.SetActive(true);
    }

    public void MiddleLevelButton()
    {
        LevelHardness = 20;
        settingsPanel.SetActive(false);
        startPanel.SetActive(true);
    }

    public void HardLevelButton()
    {
        LevelHardness = 10;
        settingsPanel.SetActive(false);
        startPanel.SetActive(true);
    }
}
