using UnityEngine;

public class EnemyShell : MonoBehaviour
{

    [SerializeField]Rigidbody2D rigidBody = null;
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Enemy�^�O�����Q�[���I�u�W�F�N�g�i���e�ہj�ɓ������������
        if (collision.gameObject.CompareTag("checkground")|| collision.gameObject.CompareTag("Shell") || collision.gameObject.CompareTag("Player"))
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
