using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveMet : MonoBehaviour
{
    public static bool metObjective;

    // Start is called before the first frame update
    void Start()
    {
        metObjective = false;
    }

    void Update()
    {
        if (metObjective)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            metObjective = true;
        }
    }
}
