using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomProjectile : BaseProjectile
{
    public float xDir = 0f; 
    public float yDir = 0f; 
    
    // Start is called before the first frame update
    void Start()
    {
        xDir = Random.Range(-1f, 1f);
        yDir = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        thisObject.transform.position += new Vector3 (xDir, yDir, 0) * speed;
    }
}
