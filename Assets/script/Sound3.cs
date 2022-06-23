using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound3 : MonoBehaviour
{
    AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        clip = gameObject.GetComponent<AudioSource>().clip;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().PlayOneShot(clip);
        }

    }
}
