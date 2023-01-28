using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningMove : MonoBehaviour
{
    public Vector3 distance = new Vector3(0, 0);
    Vector3 goal;

    public float MoveSpeed = 0.005f;

    public GameObject customer;
    public Sprite surprisedCustomer;
    public GameObject clouds;
    public GameObject smoke;
    public GameObject exclamationMark;

    Vector3 customerOriginPos;
    Vector3 smokeOriginPos;

    // Start is called before the first frame update
    void Start()
    {
        customerOriginPos = customer.transform.position;
        smokeOriginPos = smoke.transform.position;
        goal = transform.position + distance;
    }

    // Update is called once per frame
    void Update()
    {
        //if (customer.transform.position.x < (customerOriginPos + distance/2).x)
        //{
        //    //Debug.Log("중간쯤 왔어요");
        //    if (smoke.transform.position.x < -5.5)
        //    {
        //        smoke.transform.position += Vector3.right * MoveSpeed * Time.deltaTime;
        //    }
        //    else
        //    {
        //        customer.transform.GetComponent<SpriteRenderer>().sprite = surprisedCustomer;
        //        exclamationMark.SetActive(true);
        //    }
        //}

        //if (customer.transform.position.x > (customerOriginPos + distance).x)
        //{
        //    customer.transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
        //}
        //clouds.transform.position += Vector3.right * 1 * Time.deltaTime;

        if(smoke.transform.position.x > -6.1)
        {
            customer.transform.GetComponent<SpriteRenderer>().sprite = surprisedCustomer;
            exclamationMark.SetActive(true);
        }
    }

    void Move(Vector3 goal, float MoveSpeed)
    {
        transform.position = Vector2.MoveTowards(transform.position, goal, MoveSpeed);

    }
}
