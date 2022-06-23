using UnityEngine;
using UnityEngine.SceneManagement;

public class Life_Manager : MonoBehaviour
{
    [SerializeField] float m_initialSpeed = 5f;
    [SerializeField] GameObject m_effectPrefab = default;
    //[SerializeField] Rigidbody2D rigidBody = null;
    private int counter = 0;
   // const int counterMax = 20;  //最大値
    void Start()
    {

    }

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Enemyタグをもつゲームオブジェクト（＝弾丸）に当たったら消滅
        if (collision.gameObject.CompareTag("Enemy"))
        {
            counter++;
            if (m_effectPrefab)
            {
                Instantiate(m_effectPrefab, this.transform.position, this.transform.rotation);
            }
            if (counter==1)
            {
                //DeleteTargetObj という名前のオブジェクトを取得
                GameObject obj = GameObject.Find("HP");
                // 指定したオブジェクトを削除
                Destroy(obj);
            }
            if (counter == 2)
            {
                //DeleteTargetObj という名前のオブジェクトを取得
                GameObject obj = GameObject.Find("HP2");
                // 指定したオブジェクトを削除
                Destroy(obj);
            }
            if (counter == 3)
            {
                //DeleteTargetObj という名前のオブジェクトを取得
                GameObject obj = GameObject.Find("HP3");
                // 指定したオブジェクトを削除
                Destroy(obj);
            }
            if (counter == 4)
            {
                //DeleteTargetObj という名前のオブジェクトを取得
                GameObject obj = GameObject.Find("HP4");
                // 指定したオブジェクトを削除
                Destroy(obj);
            }
            if (counter == 5)
            {
                //DeleteTargetObj という名前のオブジェクトを取得
                GameObject obj = GameObject.Find("HP5");
                // 指定したオブジェクトを削除
                Destroy(obj);
                SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
            }
        }
    }
    
}