using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 cameraOffset = new Vector3(0, 0, -10);

    // TODO: make camera follow the player smooth
    void Update()
    {
        transform.position = player.position + cameraOffset;
    }
}
