using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueProjectile : BaseProjectile
{
    public GameObject targetTower; 

    public bool canHit = true;


    // Start is called before the first frame update
    void Start()
    {
        targetTower = GameObject.FindWithTag("Tower");
         canHit = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(targetTower)
        {
        thisObject.transform.position += VectorToTower() * speed;
         }

    }
     Vector3 VectorToTower()
    {
        Vector3 targetDirection;
        targetDirection = targetTower.transform.position - transform.position; 
        targetDirection = targetDirection.normalized; 

        return targetDirection; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {

         Debug.Log(" any hit");

        if (other.gameObject.tag == "Tower" && canHit)
        {
            Debug.Log("hit");
            canHit = false;
            other.gameObject.GetComponent<CharacterBase>().health -= 5;
            Destroy(gameObject);
        }
    }
}
