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
    public GameObject startText;
    public GameObject player; 
    public GameObject Score;
    public GameObject WinTextObject;
    public int scoreValue = 0;
    public AudioSource Source;
    public AudioClip Win;
    public GameObject winParticleObject;

    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();        
        startText.SetActive(true);
        StartCoroutine(StartScreen());
        WinTextObject.SetActive(false);
        winParticleObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hozMovement = Input.GetAxis("Horizontal");
        float vertMovement = Input.GetAxis("Vertical");
        rd2d.AddForce(new Vector2(hozMovement * speed, vertMovement * speed));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            scoreValue = scoreValue + 1;
            
        }

        if(scoreValue>=5)
        {
            WinTextObject.SetActive(true);
            Source.PlayOneShot(Win);
        } 
    }

    IEnumerator StartScreen()
    {
        yield return new WaitForSeconds (2);
        startText.SetActive(false);
    }
}


   
