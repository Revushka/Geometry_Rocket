using UnityEngine;

public class ForBonus : MonoBehaviour
{
    public GameObject effectScore;
    [SerializeField] GameObject bonus;
    private float speed = 5f;

    private void FixedUpdate()
    {
        Instantiate(effectScore, transform.position, Quaternion.identity);
        bonus.transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
