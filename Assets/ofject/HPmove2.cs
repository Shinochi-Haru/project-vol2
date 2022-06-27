using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPmove2 : MonoBehaviour
{

    GameObject playerObj3;
    Player player3;
    Transform playerTransform3;
    void Start()
    {
        playerObj3 = GameObject.FindGameObjectWithTag("Player");
        player3 = playerObj3.GetComponent<Player>();
        playerTransform3 = playerObj3.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Background();
    }

    void Background()
    {

        //â°ï˚å¸ÇæÇØí«è]
        transform.position = new Vector3(playerTransform3.position.x -10, transform.position.y, transform.position.z);
    }

}
