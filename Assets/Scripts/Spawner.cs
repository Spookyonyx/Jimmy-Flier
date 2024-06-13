using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject treePrefab;
    [SerializeField] float time = 2f;

    [SerializeField] float minY = -2f, maxY = 2f;


       void Start()
    {
        
        InvokeRepeating(nameof(Spawn), time, time);
    }

  
    void Update()
    {

    }
    void Spawn()
    {
        GameObject newTrees = Instantiate(treePrefab, transform.position, Quaternion.identity);
        newTrees.transform.position += new Vector3(0, Random.Range(minY, maxY));
    }
}
