using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProjectile : MonoBehaviour
{
    public float speed = 0.5f; 
    public GameObject thisObject; 

    public float lifeTime = 3f;
    public float timer = 0f; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeTime)
        { 
            Destroy(gameObject);
        } 
    }
}
