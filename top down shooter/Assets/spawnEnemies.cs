using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{
    public int wave = 1;
    public GameObject enemy;
    public Transform parrentInHierarchy;
    public Transform positionToInstantiate;
    public float timer=3f;

    private float time;

    private void Start()
    {
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= timer)
        {
            time = 0;
            for (int i = 0; i < wave; i++)
            {
                var _enemy = Instantiate(enemy, positionToInstantiate.position, enemy.transform.rotation, parrentInHierarchy);
                setEnemyTarget(_enemy);
            }

        }
    }

    void setEnemyTarget(GameObject enemy)
    {
        var player = FindObjectOfType<Move>();
        enemy.GetComponent<Pathfinding.AIDestinationSetter>().target = player.transform;
    }
}
