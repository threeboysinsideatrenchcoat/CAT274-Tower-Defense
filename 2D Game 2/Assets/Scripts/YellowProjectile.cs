using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowProjectile : BaseProjectile
{
    public GameObject targetPlayer; 
    // Start is called before the first frame update
    void Start()
    {
        targetPlayer = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        thisObject.transform.position += VectorToPlayer() * speed; 
    }
     Vector3 VectorToPlayer()
    {
        Vector3 targetDirection;
        targetDirection = targetPlayer.transform.position - transform.position; 
        targetDirection = targetDirection.normalized; 

        return targetDirection; 
    }

        void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.tag == "Shield")
        {
            Debug.Log("Deleted bullet");
            Destroy(gameObject);
        }
    }
}
