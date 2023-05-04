using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveMet : MonoBehaviour
{
    public bool metObjective;

    // Start is called before the first frame update
    void Start()
    {
        metObjective = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            metObjective = true;
        }
    }
}
