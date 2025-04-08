using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotLaser : MonoBehaviour
{

public GameObject Pivot;
public float speed = 0.01f;

public bool isMoving =false;

public GameObject[] EnemyBullets;

    public void SetEnemyState(int index, bool shouldnowbeon)
    {
        EnemyBullets[index].SetActive(shouldnowbeon);
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartMoving",1f);
    }

    void StartMoving()
    {

         isMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
              Pivot.transform.Rotate(new Vector3(0,0,1 * speed)); 
        }
        //play around with this 
    }
}
