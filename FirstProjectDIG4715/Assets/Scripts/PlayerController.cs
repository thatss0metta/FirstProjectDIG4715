using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rd2d;
    private float horizontal;
    private float speed = 8f;
    private int scoreValue = 0;
    public GameObject startText;
    public GameObject player; 
    public GameObject Score;
    

    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        Score.scoreValue = "Score";
        Score = scoreValue.ToString();        
        startText.SetActive(true);
        StartCoroutine(StartScreen());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hozMovement = Input.GetAxis("Horizontal");
        float vertMovement = Input.GetAxis("Vertical");
        rd2d.AddForce(new Vector2(hozMovement * speed, vertMovement * speed));
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.collider.tag == "Collectible")
        {
            scoreValue += 1;
            Score = scoreValue.ToString();
            Destroy(collision.collider.gameObject);
        }
    }

    IEnumerator StartScreen()
    {
        yield return new WaitForSeconds (2);
        startText.SetActive(false);
    }
}


   
