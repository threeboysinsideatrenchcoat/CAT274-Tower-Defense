using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : CharacterBase
{
    public static CharacterMovement Instance; 

    public GameObject player;
    public GameObject projectile;
    public GameObject shield;
    public float speed = 0.2f;
    public float spawnTimer = 0f;
    public float shieldTime = 0f;

    public float shieldInterval = 0.1f; 

    public bool isShield = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 
    void Update()
    {   
        shieldTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += Vector3.up * speed;
            Debug.Log("W Pressed");
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position += Vector3.down * speed;
            Debug.Log("S Pressed");
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position += Vector3.left * speed;
            Debug.Log("A Pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += Vector3.right * speed;
            Debug.Log("D Pressed");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, transform.position, Quaternion.identity); 
        Debug.Log("Left Mouse Button Clicked");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if(isShield == false)
            {
                shield.SetActive(true);
                isShield = true;
            }
        }

        if (shieldTime >= shieldInterval)
        {
            
            shield.SetActive(false);
            isShield = false;
            shieldTime = 0f;
        }
    }
    void OnCollisionEnter2D(Collision2D collison)
    { 
        if(collison.gameObject.tag == "Projectile")
        {
            health = health - 2; 
        }
        if(collison.gameObject.tag == "Projectile2")
        {
            health = health - 5; 
        }
        
    }


}