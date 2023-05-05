using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIUpdate : MonoBehaviour
{
    [Header("Main UI")]
    public GameObject mainUI;

    [Header("Game Complete Screen")]
    public GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        mainUI.SetActive(true);
        winScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjectiveMet.metObjective)
        {
            winScreen.SetActive(true);
            mainUI.SetActive(false);
        }
    }
}
