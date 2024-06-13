using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] float speed = -2f;

    void Start()
    {

    }


    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

                if(transform.position.x <= -14f)
        {
            Destroy(gameObject);
        } 
    }
}
