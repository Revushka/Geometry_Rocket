using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitcherScript : MonoBehaviour
{
    public GameObject SoundfOnTapButton;
    [SerializeField] private GameObject pauseCanvas, SwitchAcceleration, SwitchTouchOnScreen;

    public void Play()
    {
        Instantiate(SoundfOnTapButton, transform.position, Quaternion.identity);
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        Instantiate(SoundfOnTapButton, transform.position, Quaternion.identity);
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        Instantiate(SoundfOnTapButton, transform.position, Quaternion.identity);
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Instantiate(SoundfOnTapButton, transform.position, Quaternion.identity);
        Application.Quit();
    }
    public void Pause()
    {
        Instantiate(SoundfOnTapButton, transform.position, Quaternion.identity);
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
    }
    public void Continue()
    {
        Instantiate(SoundfOnTapButton, transform.position, Quaternion.identity);
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }
}
