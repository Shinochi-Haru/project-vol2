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
        // Enemy�^�O�����Q�[���I�u�W�F�N�g�i��覐΁j�ɓ������������
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("checkground"))
        {
            Destroy(gameObject);
        }
    }

    void OnBecameInvisible()
    {
        // �J�����ɉf��Ȃ��Ȃ��������
        Destroy(gameObject);
    }

}
