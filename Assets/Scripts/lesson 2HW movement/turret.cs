using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class turret : MonoBehaviour
{
    [SerializeField] GameObject rocets;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawnpoint = 1f;
    [SerializeField] float angularSpeed;
    public Transform player;
    private float nextSpavnTime;
    private void Start()
    {
        //player = FindObjectOfType<Quest.Player.PlayerMovement>().transform;
    }

    private void Update()
    {
        LookAtPlayer();
        shoot();
    }
    private void LookAtPlayer()
    {
        Vector3 direction = player.transform.position - transform.position;
        Vector3 rotation = Vector3.RotateTowards(transform.forward,direction,angularSpeed * Time.deltaTime, 0F);
        transform.rotation = Quaternion.LookRotation(rotation);
    }
    private void shoot()
    {
        if (Time.time > nextSpavnTime)
        {
            Instantiate(rocets, spawnPoint.position, spawnPoint.rotation);
            nextSpavnTime = Time.time + 2;
        }
    }
}
