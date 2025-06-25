using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] private string EnemyWeakness;
    [SerializeField] private Transform PARENT;
    [SerializeField] private AudioSource DIE_SFX;
    EnemySpawner spawner;
    private void Start()
    {
        spawner = GameObject.FindGameObjectWithTag("EnemySpawne").GetComponent<EnemySpawner>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == EnemyWeakness)
        {
            Instantiate(DIE_SFX, PARENT.position, PARENT.rotation);
            spawner.RemoveEnemy(PARENT);
            Destroy(PARENT.gameObject);
        }
    }
}