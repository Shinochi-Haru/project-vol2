using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Enemy�^�O�����Q�[���I�u�W�F�N�g�i���e�ہj�ɓ������������
        if (collision.gameObject.CompareTag("GOOL"))
        {
            SceneManager.LoadScene("Clear", LoadSceneMode.Additive);
        }
    }
}
