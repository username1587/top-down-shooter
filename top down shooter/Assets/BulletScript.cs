using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        print("orice");
        if (collision.gameObject.layer == /*LayerMask.NameToLayer("Enemy")*/8)   // if is an enemy
            Destroy(gameObject);
    }
}
