using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private Transform collecttransform;

    private bool collected = false;

    private float speed = 10;

    private void Start()
    {
        collecttransform = GameObject.Find("CollectTransform").transform;
    }

    private void Update()
    {
        Move();
    }


    private void Move()
    {
        if (collected)
        {
            transform.position = Vector3.MoveTowards(transform.position, collecttransform.position, Time.deltaTime * speed);
          
        }
        if (transform.position == collecttransform.position)
        {
          //UImanager.Instance.AddApple();
          //Destroy(gameObject);
        }
    }

    public void Collect()
    {
        collected = true;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       UImanager.Instance.AddApple();
       Destroy(gameObject);
    }
}