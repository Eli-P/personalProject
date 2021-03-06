﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmovement : MonoBehaviour
{
    public GameObject player;
    public GameObject explosion;
    public float speed = 40f;
    public float dist;
    public float vanish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

            Destroy(gameObject, 5);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (dist > 20)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
