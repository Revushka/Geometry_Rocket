using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RocketScropts : MonoBehaviour
{
    public static RocketScropts instanse;
    public GameObject effectScore;
    public GameObject effectEnemy;
    public GameObject Heart1, Heart2, Heart3;
    public GameObject Sound, SoundEnemy;
    private Animator camAnim, camAnim2, camAnim3;
    private static int HP = 3;

    private void Awake()
    {
        instanse = this;
        if (PlayerPrefs.HasKey("SaveScore"))
        {
            BetterScore = PlayerPrefs.GetInt("SaveScore");
        }
    }
    void Start()
    {
        Heart1.SetActive(true);
        Heart2.SetActive(true);
        Heart3.SetActive(true);
        HP = 3;
        camAnim3 = GameObject.FindGameObjectWithTag("HP (1)").GetComponent<Animator>();
        camAnim2 = GameObject.FindGameObjectWithTag("HP (2)").GetComponent<Animator>();
        camAnim = GameObject.FindGameObjectWithTag("HP").GetComponent<Animator>();
    }
    public int score, BetterScore;
    [SerializeField] Text scoreText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Score")
        {
            Destroy(other.gameObject);
            Instantiate(Sound, transform.position, Quaternion.identity);
            Instantiate(effectScore, transform.position, Quaternion.identity);
            instanse.AddScore();
        }
        if (other.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Your score:", score);
            Destroy(other.gameObject);
            Instantiate(SoundEnemy, transform.position, Quaternion.identity);
            Instantiate(effectEnemy, transform.position, Quaternion.identity);
            HP --;
            camAnim3.SetTrigger("shake3");
            camAnim2.SetTrigger("Shake1");
            camAnim.SetTrigger("Shake2");
           
            if (HP == 0)
            {
                Time.timeScale = 0;
                SceneManager.LoadScene(2);
            }
        }
    }
    void Update()
    {
        switch (HP)
        {
            case 3:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(true);
                break;

            case 2:
                Heart1.SetActive(true);
                Heart2.SetActive(true);
                Heart3.SetActive(false);
                break;
            case 1:
                Heart1.SetActive(true);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;
            case 0:
                Heart1.SetActive(false);
                Heart2.SetActive(false);
                Heart3.SetActive(false);
                break;
        }
        scoreText.text = score.ToString();
    }
    public void AddScore()
    {
        score++;
        HighScore();
    }
    public void HighScore()
    {
        if (score > BetterScore)
        {
            BetterScore = score;
            PlayerPrefs.SetInt("SaveScore", BetterScore);
        }
    }
    public void ResetScore()
    {
        score = 0;
    }
    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("SaveScore");

        BetterScore = 0;
    }
}
