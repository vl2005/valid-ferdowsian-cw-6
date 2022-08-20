using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DESTROY : MonoBehaviour
{
    public Text scoretext;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            score += 1;
            scoretext.text = "score =" + score.ToString();
            Destroy(collision.gameObject);
            
        }
    }
}
