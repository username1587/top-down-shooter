using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{

    Rigidbody2D myRb;
    [SerializeField] Transform player;
    [SerializeField] float speed = 1f;

    void Start()
    {
        myRb = GetComponent<Rigidbody2D>();
        var move = FindObjectOfType<Move>();
        player = move.transform;
    }

    void FixedUpdate()
    {
        var dir = (player.position - transform.position).normalized;
        //myRb.AddForce(dir * speed * Time.fixedDeltaTime);
        myRb.velocity = dir * speed * Time.fixedDeltaTime;
    }
}
