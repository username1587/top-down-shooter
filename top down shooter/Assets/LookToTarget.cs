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
        var mousePosInPixels = Input.mousePosition; // we got the mouse position in pixels
        var mousePosInCoordinates = Camera.main.ScreenToWorldPoint(mousePosInPixels);
        Vector2 dir = mousePosInCoordinates - transform.position;
        var angleInRadians = Mathf.Atan2(dir.y, dir.x);
        var angleInDegrees = angleInRadians * Mathf.Rad2Deg;
        rigidBody2d.rotation = angleInDegrees - 90f;                   // rigidbody::rotation requires degrees not gradians
                                                                       // it requires -90 degrees to aim the direction you want to
    }
}
