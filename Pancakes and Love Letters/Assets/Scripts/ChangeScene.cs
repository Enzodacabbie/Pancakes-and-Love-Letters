using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change(string name)
    {
        if (name.Contains("quit"))
        {
            
        }
        SceneManager.LoadScene(name);
    }

    public void quit()
    {
        Application.Quit();
    }
}
