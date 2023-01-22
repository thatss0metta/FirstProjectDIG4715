using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rd2d;
    private float horizontal;
    private float speed = 8f;
    private int scoreValue = 0;
    public Text score;
    
    // Start is called before the first frame update
    void Start()
    {
      rd2d = GetComponent<Rigidbody2D>();
      score.text = scoreValue.ToString();  
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
            score.text = scoreValue.ToString();
            Destroy(collision.collider.gameObject);
        }
    }
}    
