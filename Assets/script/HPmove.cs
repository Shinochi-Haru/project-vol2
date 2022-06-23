using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPmove : MonoBehaviour
{

    GameObject playerObj2;
    Player player2;
    Transform playerTransform2;
    void Start()
    {
        playerObj2 = GameObject.FindGameObjectWithTag("Player");
        player2 = playerObj2.GetComponent<Player>();
        playerTransform2 = playerObj2.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Background();
    }

    void Background()
    {

        //â°ï˚å¸ÇæÇØí«è]
        transform.position = new Vector3(playerTransform2.position.x-9, transform.position.y, transform.position.z);
    }

}
