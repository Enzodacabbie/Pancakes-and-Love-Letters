using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bowl : MonoBehaviour
{
    public static float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("added ingredient");

        StartCoroutine(destroyIngredient(other.gameObject));
    }
    private IEnumerator destroyIngredient(GameObject obj){
      yield return new WaitForSeconds(5);
      Destroy(obj);
 }
}
