using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void TitleScene()
    {
        SceneManager.LoadScene("TitleMenu");
    }

    public void Overworld()
    {
        SceneManager.LoadScene("Overworld");
    }

    public void MiniGame()
    {
        SceneManager.LoadScene("Cooking");
    }
}
