using System.Collections;
using UnityEngine;

public class ForSpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy, score;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        Instantiate(Random.Range(1, 90) <= 45 ? enemy : score, new Vector2(transform.position.x + Random.Range(-2.1f, 2.1f), transform.position.y), transform.rotation);
        yield return new WaitForSeconds(1.5f);
        Repeat();
    }
    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
