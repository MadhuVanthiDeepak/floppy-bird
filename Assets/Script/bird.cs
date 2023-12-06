using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class bird : MonoBehaviour
{
    public Rigidbody2D rb;
     public float score;
    [SerializeField]public float HighScore;
   [SerializeField] public TMP_Text scoreText; 
    [SerializeField] public TMP_Text HighscoreText;
    [SerializeField] public float jumpforce;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb=GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

       
        rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "spike")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
    public void UpdateScore()
    {
        score+=1f;
        print(score);
        scoreText.text = score.ToString();
        audio.Play();
    }
}

