using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MainCamera))]
public class MainCamera : MonoBehaviour
{

    GameObject playerObj;
    Player player;
    Transform playerTransform;

    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<Player>();
        playerTransform = playerObj.transform;
    }

    void LateUpdate()
    {
        MoveCamera();
    }

    void MoveCamera()
    {

        //â°ï˚å¸ÇæÇØí«è]
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
    }

}