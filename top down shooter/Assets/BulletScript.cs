using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        print("orice");
        if (other.gameObject.layer == /*LayerMask.NameToLayer("Enemy")*/8)
        {
            // if is an enemy
            other.gameObject.GetComponent<enemyLife>().life--;
            Destroy(gameObject);
        }
    }
}
