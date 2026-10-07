using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{

    public GameObject leftBorder;
    public GameObject rightBorder;
    public Rigidbody2D rigidbody;
    public bool isRightDirection;
    public float speed;



    void Update()
    {
        if (isRightDirection)
        {
            rigidbody.velocity = Vector2.right * speed;
        }
        else
            rigidbody.velocity = Vector2.left * speed;


        if (rigidbody.transform.position.x > rightBorder.transform.position.x)
        {
            isRightDirection = false;
        }
        else if (rigidbody.transform.position.x < leftBorder.transform.position.x)
        {
            isRightDirection = true;
        }


    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy")
    //    {
    //       // takeHit(20);
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Health>().takeHit(20);
            

        }
    }
}
