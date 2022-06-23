using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPmove4 : MonoBehaviour
{

    GameObject playerObj5;
    Player player5;
    Transform playerTransform5;
    void Start()
    {
        playerObj5 = GameObject.FindGameObjectWithTag("Player");
        player5 = playerObj5.GetComponent<Player>();
        playerTransform5 = playerObj5.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Background();
    }

    void Background()
    {

        //â°ï˚å¸ÇæÇØí«è]
        transform.position = new Vector3(playerTransform5.position.x - 12, transform.position.y, transform.position.z);
    }

}
