using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int score;
    public SC_InventorySystem sc_InventorySystem;

    Text text;


    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }


    void Update()
    {
        text.text = "Score: " + sc_InventorySystem.CollectedItemsCount;
    }
}
