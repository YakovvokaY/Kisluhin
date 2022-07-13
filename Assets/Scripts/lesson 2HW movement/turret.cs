using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class turret : MonoBehaviour
{
    [SerializeField] GameObject rocets;
    private float nextSpavnTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpavnTime)
        {
            Instantiate(rocets,transform);
            nextSpavnTime = Time.time + 2;
        }
    }
}
