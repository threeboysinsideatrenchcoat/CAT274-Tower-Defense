using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tower : CharacterBase
{
    public GameObject projectile; 
    public float spawnTimer = 0f; 
    public float spawnInterval = 0.5f;
    Vector3 spawnPosition; 
    void Update()
    {
        Health();
        DisplayHealth();
        spawnTimer += Time.deltaTime; 
        if (spawnTimer >= spawnInterval)
        {
           Instantiate(projectile, transform.position, Quaternion.identity); 
           spawnTimer = 0f;
        } 
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("colliding with Player");
            health = health - 3;
            Destroy(collision.gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "BlobProjectile")
        {
            Debug.Log("Triggered blob projectile");
            health = health - 9;
            Destroy(other.gameObject);
        }
    }
}
