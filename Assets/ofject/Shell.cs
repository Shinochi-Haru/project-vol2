using UnityEngine;

public class Shell : MonoBehaviour
{

    [SerializeField]
    Rigidbody2D rigidBody = null;
   

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Enemyタグをもつゲームオブジェクト（＝隕石）に当たったら消滅
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("checkground"))
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        // カメラに映らなくなったら消滅
        Destroy(gameObject);
    }

}
