using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform bulletSpawnLocation;
    [SerializeField] float speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet=Instantiate(bulletPrefab, bulletSpawnLocation.position, bulletPrefab.transform.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(bulletSpawnLocation.up * speed, ForceMode2D.Impulse);    // is here a memory leak?
            Destroy(bullet, 3f);
        }
    }
}
