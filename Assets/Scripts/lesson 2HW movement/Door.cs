using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private bool flag = false;
    private bool flag2 = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (flag == true && transform.rotation.y != 90)
        {
            transform.Rotate(new Vector3(0,1,0)*Time.deltaTime);
            if (transform.rotation.y == 90)
            {
                flag = false;
            }
        }
        if (flag == false && transform.rotation.y != 0)
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime);
            if (transform.rotation.y == 0)
            {
                flag = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            flag2 = !flag2;
        }
    }
}