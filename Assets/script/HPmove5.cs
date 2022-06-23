using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPmove5 : MonoBehaviour
{

    GameObject playerObj6;
    Player player6;
    Transform playerTransform6;
    void Start()
    {
        playerObj6 = GameObject.FindGameObjectWithTag("Player");
        player6 = playerObj6.GetComponent<Player>();
        playerTransform6 = playerObj6.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Background();
    }

    void Background()
    {

        //â°ï˚å¸ÇæÇØí«è]
        transform.position = new Vector3(playerTransform6.position.x - 13, transform.position.y, transform.position.z);
    }

}
