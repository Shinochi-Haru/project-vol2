using UnityEngine;

/// <summary>
/// �K���}���̃L�����N�^�[�𑀍삷��R���|�[�l���g
/// </summary>
public class Jamp: MonoBehaviour
{
    /// <summary>���E�ړ������</summary>
    [SerializeField] float m_movePower = 10f;
    /// <summary>�W�����v�����</summary>
    [SerializeField] float m_jumpPower = 15f;
    /// <summary>�F�̔z��</summary>
    [SerializeField] Color[] m_colors = default;
    /// <summary>�e�ۂ̃v���n�u</summary>
    [SerializeField] GameObject m_bulletPrefab = default;
    /// <summary>�e���̈ʒu��ݒ肷��I�u�W�F�N�g</summary>
    [SerializeField] Transform m_muzzle = default;
    /// <summary>���͂ɉ����č��E�𔽓]�����邩�ǂ����̃t���O</summary>
    [SerializeField] bool m_flipX = false;
    Rigidbody2D m_rb = default;
    SpriteRenderer m_sprite = default;
    /// <summary>m_colors �Ɏg���Y��</summary>
    int m_colorIndex;
    /// <summary>���������̓��͒l</summary>
    float m_h;
    float m_scaleX;
    /// <summary>�ŏ��ɏo���������W</summary>
    Vector3 m_initialPosition;
    [SerializeField] float m_speed = 0;
    int num = 0;
    bool nidan = false;

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        m_sprite = GetComponent<SpriteRenderer>();
        // �����ʒu���o���Ă���
        m_initialPosition = this.transform.position;
    }

    void Update()
    {
        // ���͂��󂯎��
        m_h = Input.GetAxisRaw("Horizontal");

        // �e����͂��󂯎��
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("�����ɃW�����v���鏈���������B");
            if (checkground)
            {
                nidan = true;
                m_rb.AddForce(Vector2.up * m_jumpPower, ForceMode2D.Impulse);
            }
            else if (nidan)
            {
                nidan = false;
                m_rb.AddForce(Vector2.up * m_jumpPower, ForceMode2D.Impulse);
            }
        }

       


        // �ݒ�ɉ����č��E�𔽓]������
        if (m_flipX)
        {
            FlipX(m_h);
        }
    }

    private void FixedUpdate()
    {
        // �͂�������̂� FixedUpdate �ōs��
         m_rb.AddForce(Vector2.right * m_h * m_movePower, ForceMode2D.Force);
        
    }

    /// <summary>
    /// ���E�𔽓]������
    /// </summary>
    /// <param name="horizontal">���������̓��͒l</param>
    void FlipX(float horizontal)
    {
        /*
         * ������͂��ꂽ��L�����N�^�[�����Ɍ�����B
         * ���E�𔽓]������ɂ́ATransform:Scale:X �� -1 ���|����B
         * Sprite Renderer �� Flip:X �𑀍삵�Ă����]����B
         * */
        m_scaleX = this.transform.localScale.x;

        if (horizontal > 0)
        {
            isreturn = false;
            this.transform.localScale = new Vector3(Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
        }
        else if (horizontal < 0)
        {
            isreturn = true;
            this.transform.localScale = new Vector3(-1 * Mathf.Abs(this.transform.localScale.x), this.transform.localScale.y, this.transform.localScale.z);
        }
    }
    bool checkground = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        checkground = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        checkground = false;
    }
    public bool isreturn = false;

}
