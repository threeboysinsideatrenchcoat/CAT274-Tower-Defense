using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : CharacterBase
{
    public GameObject projectile; 
    public float spawnTimer = 0f; 
    public float spawnInterval = 0.5f;
    Vector3 spawnPosition; 
    private void Update()
    {
        spawnTimer += Time.deltaTime; 
        if (spawnTimer >= spawnInterval)
        {
           Instantiate(projectile, transform.position, Quaternion.identity); 
           spawnTimer = 0f;
        } 
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("colliding with enemy");
            health = health - 10;
            Destroy (collision.gameObject);
        }
    }
}
