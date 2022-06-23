using UnityEngine;

public class EnemyShell : MonoBehaviour
{

    [SerializeField]Rigidbody2D rigidBody = null;
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Enemyタグをもつゲームオブジェクト（＝弾丸）に当たったら消滅
        if (collision.gameObject.CompareTag("checkground")|| collision.gameObject.CompareTag("Shell") || collision.gameObject.CompareTag("Player"))
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
