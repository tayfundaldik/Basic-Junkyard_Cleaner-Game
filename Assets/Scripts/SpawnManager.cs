using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float randomspawnPosZ;
    [SerializeField] GameObject[] junks;
    private float starts = 1.0f;
    private float interval = 1.0f;
    float posZrange=15;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSomeJunk",starts,interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnSomeJunk(){
        randomspawnPosZ = Random.Range(-posZrange,posZrange);
        Vector3 SpawnPos = new Vector3(0,15,randomspawnPosZ);
        int index = Random.Range(0,junks.Length);
        Instantiate(junks[index],SpawnPos,junks[index].transform.rotation);
    }

}
