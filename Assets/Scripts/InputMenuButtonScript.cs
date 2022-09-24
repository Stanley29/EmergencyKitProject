using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputMenuButtonScript : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject startPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void SettingsButton()
    {
        settingsPanel.SetActive(true);
        startPanel.SetActive(false);
    }

}
