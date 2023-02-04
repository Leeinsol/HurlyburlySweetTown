using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer : MonoBehaviour
{
    public Vector3 goal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x <= goal.x)
        {
            Debug.Log("goal");
            transform.GetComponent<Animator>().SetBool("isWalking", false);
        }    
    }
}
