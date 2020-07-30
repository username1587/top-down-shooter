using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToTarget : MonoBehaviour
{
    Rigidbody2D rigidBody2d;
    
    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        LookToMousePosition();
    }

    // makes player look to the current position of the mouse
    private void LookToMousePosition()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var dir = mousePos - rigidBody2d.position;
        rigidBody2d.MoveRotation(Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f);
    }
}
