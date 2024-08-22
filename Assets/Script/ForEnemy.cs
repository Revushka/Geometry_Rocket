using UnityEngine;

public class ForEnemy : MonoBehaviour
{
    public GameObject effectEnemy;
    [SerializeField] GameObject enemy;
    private float speed = 6.5f;
    private void FixedUpdate()
    {
        Instantiate(effectEnemy, transform.position, Quaternion.identity);
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
    
}
