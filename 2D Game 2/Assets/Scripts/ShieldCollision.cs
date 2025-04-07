using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position;
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
