using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
   [SerializeField] private GameObject[] buildingPrefabs;
   [SerializeField] private Transform[] spawnLocation;

   private void Start(){
    Generate();
}

private void Generate(){
    for(int i = 0; i < spawnLocation.Length; i++){
        int ranNum = Random.Range(0, buildingPrefabs.Length);
        GameObject building = Instantiate(buildingPrefabs[ranNum], spawnLocation[i].position, buildingPrefabs[ranNum].transform.rotation);
        building.transform.rotation = spawnLocation[i].transform.rotation;
        building.transform.SetParent(spawnLocation[i]);
    }
}
}


