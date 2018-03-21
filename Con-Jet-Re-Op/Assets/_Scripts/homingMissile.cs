using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class homingMissile : MonoBehaviour {

    public Transform target;

    public float speed = 5f;
    public float rotateSpeed = 200f;
    public GameObject explosionEffect;

    private Rigidbody rb;


	void Start () {
        rb = GetComponent<Rigidbody>();
        //target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void FixedUpdate () {
        //Cross Product
        Vector3 direction = target.position - rb.position;

        direction.Normalize();

        Vector3 rotateAmount = Vector3.Cross(direction, transform.up);

        rb.angularVelocity = -rotateAmount * rotateSpeed;

        rb.velocity = transform.up * speed;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
