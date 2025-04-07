using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.tag == "Projectile2")
        {
            Debug.Log("Deleted bullet");
            Destroy(other.gameObject);
        }
    }
}
