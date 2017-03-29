using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    PlayerMove myObj;

    public GameObject player;

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        //set offset to difference in camera osition to the playuer position
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //set position to players positoi + offset
        transform.position = player.transform.position + offset;

    }
}