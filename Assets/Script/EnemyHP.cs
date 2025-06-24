using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private string EnemyWeakness;
    [SerializeField] private Transform PARENT;
    EnemySpawner spawner;
    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("EnemySpawne").GetComponent<EnemySpawner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == EnemyWeakness)
        {
            //moze spawn sfx
            spawner.RemoveEnemy(PARENT);
            Destroy(PARENT.gameObject);
        }
    }
}