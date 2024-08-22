using UnityEngine;

public class MoveRocket : MonoBehaviour
{
    public GameObject effectRocket;
    //private float rightBorder = 2.19f, leftBorder = -2.19f;
    private float speed = 15f;
    void Start()
    {
        Time.timeScale = 1;
    }

    
    void FixedUpdate()
    {
        Vector2 acceleration = Input.acceleration;
        Instantiate(effectRocket, transform.position, Quaternion.identity);
        GetComponent<Rigidbody2D>().velocity = new Vector2(acceleration.x * speed, 0f);
    }

    /*void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x > Screen.width/2)
            {
                if (transform.position.x < rightBorder)
                {
                    Instantiate(effectRocket, transform.position, Quaternion.identity);
                    transform.Translate(Vector2.right * speed * Time.deltaTime);
                }
            }
            else
            {
                if (transform.position.x > leftBorder)
                {
                    Instantiate(effectRocket, transform.position, Quaternion.identity);
                    transform.Translate(Vector2.left * speed * Time.deltaTime);
                }
            }
        }
    }*/
}
