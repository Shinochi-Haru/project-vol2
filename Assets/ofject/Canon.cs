using UnityEngine;

public class Canon : MonoBehaviour
{

    public GameObject Shell;
    [SerializeField] float speed;

    void Start()
    {
        speed = 10.0f;  // �e�̑��x
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            // �e�i�Q�[���I�u�W�F�N�g�j�̐���
            GameObject clone = Instantiate(Shell, transform.position, Quaternion.identity);

            // �N���b�N�������W�̎擾�i�X�N���[�����W���烏�[���h���W�ɕϊ��j
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // �����̐����iZ�����̏����Ɛ��K���j
            Vector2 shotForward = Vector3.Scale(mouseWorldPos - transform.position, new Vector3(1, 1, 0)).normalized;

            // �e�ɑ��x��^����
            clone.GetComponent<Rigidbody2D>().velocity = shotForward * speed;


        }
    }
}