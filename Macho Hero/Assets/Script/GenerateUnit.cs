using UnityEngine;
using System.Collections;

public class GenerateUnit : MonoBehaviour {

public GameObject unit;

private float timeToSpawn = 0.0f;
public float spawnTime = 50.0f;

    void Update () {

       timeToSpawn += 1.0f;
        if(timeToSpawn >= spawnTime)
        {
        GameObject SpawnLocation = (GameObject)Instantiate(unit,transform.position,Quaternion.identity);
        timeToSpawn = 0;
        }
    }
}
