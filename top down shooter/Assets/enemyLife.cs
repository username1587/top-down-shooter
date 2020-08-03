using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLife : MonoBehaviour
{
    public int life = 3;

    private void Update()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

}
