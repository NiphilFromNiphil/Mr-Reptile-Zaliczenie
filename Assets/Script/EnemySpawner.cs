using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using NUnit.Framework;
using System.Collections.Generic;
using TMPro;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform POINT1;
    [SerializeField] private Transform POINT2;
    [SerializeField] private Transform[] SPAWNEE;
    [SerializeField] private Transform NEXT_LEVEL_SIGN_POS;
    [SerializeField] private Transform NEXT_LEVEL_ENTRY;
    [SerializeField] private int onstart;
    public List<Transform> enemies = new List<Transform>();
    TextMeshProUGUI zzabto;

    bool won;
    private float timer = 1.0f;

    public void RemoveEnemy(Transform trans)
    {
        enemies.Remove(trans);
    }
    private void Start()
    {
        for (int i = 0; i < onstart; i++)
        {
            Vector2 pos = new Vector2(Random.Range(POINT1.position.x, POINT2.position.x), POINT1.position.y);
            enemies.Add(Instantiate(SPAWNEE[Random.Range(0, SPAWNEE.Length)], pos, POINT1.rotation));
        }

        zzabto = GameObject.FindGameObjectWithTag("Zabto").GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        if (enemies.Count <= 0)
        {
            if (won == false)
            {
                zzabto.enabled = true;
                if (NEXT_LEVEL_ENTRY != null)
                {
                    Instantiate(NEXT_LEVEL_ENTRY, NEXT_LEVEL_SIGN_POS.position, NEXT_LEVEL_SIGN_POS.rotation);
                }
                won = true;
            }
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
                enemies.Add(Instantiate(SPAWNEE[Random.Range(0, SPAWNEE.Length)], pos, POINT1.rotation));
                timer = 20.0f;
            }
        }
    }
}
