using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Score")
        {
            Destroy(other.gameObject);
        }
    }
}
