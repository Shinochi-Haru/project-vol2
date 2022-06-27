using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPmove3 : MonoBehaviour
{

    GameObject playerObj4;
    Player player4;
    Transform playerTransform4;
    void Start()
    {
        playerObj4= GameObject.FindGameObjectWithTag("Player");
        player4= playerObj4.GetComponent<Player>();
        playerTransform4 = playerObj4.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Background();
    }

    void Background()
    {

        //â°ï˚å¸ÇæÇØí«è]
        transform.position = new Vector3(playerTransform4.position.x - 11, transform.position.y, transform.position.z);
    }

}
