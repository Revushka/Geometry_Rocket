using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreHandler : MonoBehaviour
{
    public GameObject effect;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public int score;
    [SerializeField] Text scoreText;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "bonus")
        {
            Destroy(other.gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);
            score++;
        }

        if (other.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Your score:", score);
            Destroy(other.gameObject);
            score = 0;
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
