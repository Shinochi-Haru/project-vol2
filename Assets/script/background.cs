using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background: MonoBehaviour
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

    // Update is called once per frame
    void LateUpdate()
    {
        Background();
    }

    void Background()
    {

        //â°ï˚å¸ÇæÇØí«è]
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
    }

}
