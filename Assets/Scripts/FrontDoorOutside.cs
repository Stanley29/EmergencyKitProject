using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FrontDoorOutside : MonoBehaviour
{
    public Text outText;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // SceneManager.LoadScene(2);
        panel.SetActive(true);
        outText.text = "Are you sure to get out?";
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
        Cursor.visible = false;  //collected items list initiate
        Cursor.lockState = CursorLockMode.Locked;
    }
}
