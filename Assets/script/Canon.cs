using UnityEngine;

public class Canon : MonoBehaviour
{

    public GameObject Shell;
    [SerializeField] float speed;

    void Start()
    {
        speed = 10.0f;  // 弾の速度
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            // 弾（ゲームオブジェクト）の生成
            GameObject clone = Instantiate(Shell, transform.position, Quaternion.identity);

            // クリックした座標の取得（スクリーン座標からワールド座標に変換）
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // 向きの生成（Z成分の除去と正規化）
            Vector2 shotForward = Vector3.Scale(mouseWorldPos - transform.position, new Vector3(1, 1, 0)).normalized;

            // 弾に速度を与える
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;


        }
    }
}