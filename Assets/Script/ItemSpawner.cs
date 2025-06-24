using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private Transform POINT1;
    [SerializeField] private Transform POINT2;
    [SerializeField] private Item[] SPAWNEE;

    private float timer = 1.0f;

    private void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Vector2 pos = new Vector2(Random.Range(POINT1.position.x, POINT2.position.x), POINT1.position.y);
            Instantiate(SPAWNEE[Random.Range(0, SPAWNEE.Length)], pos, POINT1.rotation);
        }
    }
    private void FixedUpdate()
    {
        if (timer >= 0.0f)
        {
            timer -= 0.017f;
            if (timer < 0.0f)
            {
                Vector2 pos = new Vector2(Random.Range(POINT1.position.x, POINT2.position.x), POINT1.position.y);
                Instantiate(SPAWNEE[Random.Range(0, SPAWNEE.Length)], pos, POINT1.rotation);
                timer = 5.0f;
            }
        }
    }
}
