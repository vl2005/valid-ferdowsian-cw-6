using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player2 : MonoBehaviour
{
    public float inc;

    public float minpos;
    public float maxpos;

    public AudioSource src;

    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    void Update()
    {
        move();
    }

    void move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, maxpos, minpos), transform.position.y, transform.position.z);
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, maxpos, minpos), transform.position.y, transform.position.z);

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {   
            src.Play();
            Invoke("Restart", 5f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(0);
    }

}

