using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueProjectile : BaseProjectile
{
    public GameObject targetTower; 
    // Start is called before the first frame update
    void Start()
    {
        targetTower = GameObject.FindWithTag("Tower");
    }

    // Update is called once per frame
    void Update()
    {
        thisObject.transform.position += VectorToTower() * speed; 
    }
     Vector3 VectorToTower()
    {
        Vector3 targetDirection;
        targetDirection = targetTower.transform.position - transform.position; 
        targetDirection = targetDirection.normalized; 

        return targetDirection; 
    }
}
