using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleSpawner : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        StartCoroutine(SpawnPrefab1());
        StartCoroutine(SpawnPrefab2());
    }

    IEnumerator SpawnPrefab1()
    {
        yield return new WaitForSeconds(2f);
        //Instantiate(prefab, new Vector2(2.4,4.7), Quaternion.identity);
    }

    IEnumerator SpawnPrefab2()
    {
        yield return new WaitForSeconds(4f);
        //Instantiate(prefab, new Vector2(3.5, 5.2), Quaternion.identity);
    }
}