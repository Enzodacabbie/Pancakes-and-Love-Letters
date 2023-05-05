using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    [SerializeField] GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggle()
    {
        if(obj.activeSelf)
        {
            obj.SetActive(false);
        }
        else
            obj.SetActive(true);
    }
}
