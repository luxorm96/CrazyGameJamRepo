using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D rb;//need this to move enemy
    public GameObject earth;

    [Header("Attributes")]
    [SerializeField] private float moveSpeed = 2f;

    private void Start()
    {
        

    }

    private void Update()
    {
        //if(Vector2.Distance(earth.transform.position, transform.position) > (earth.GetInstanceID<CircleCollider2D>.radius + 0.5f))
        //{

        //}
        //else
        //    transform.RotateAround(earth.transform.position, earth.transform.up, 100 * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Vector2 direction = (earth.transform.position-transform.position).normalized;

        rb.velocity = direction * moveSpeed;
    }
}
