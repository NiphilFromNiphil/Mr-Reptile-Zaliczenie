using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float MaxHP;
    public Image HPBar;
    private float HP;
    public Transform DIE_UI;
    public TextMeshProUGUI left;
    EnemySpawner spawner;

    string curscene;
    float DieTimer = 0.0f;

    private void Start()
    {
        HP = MaxHP;
        curscene = SceneManager.GetActiveScene().name;
        GameObject spawnobj = GameObject.FindGameObjectWithTag("EnemySpawne");
        if (spawnobj != null )
        {
            spawner = spawnobj.GetComponent<EnemySpawner>();
        }
    }

    private void Update()
    {
        if (spawner != null && left != null)
        {
            left.text = spawner.enemies.Count.ToString() + " Left...";
        }
    }

    private void FixedUpdate()
    {
        if (DieTimer > 0.0f)
        {
            DieTimer -= 0.017f;
            if (DieTimer <= 0.0f)
            {
                SceneManager.LoadScene(curscene);
                DieTimer = 0.0f;
            }
        }
    }
    public void Hit(float dmg)
    {
        HP -= dmg;
        HPBar.fillAmount = HP / MaxHP;

        if (HP <= 0.0f)
        {
            if (DieTimer <= 0.0f)
            {
                DIE_UI.gameObject.SetActive(true);
                TextMeshProUGUI zzabto = GameObject.FindGameObjectWithTag("Zabto").GetComponent<TextMeshProUGUI>();
                zzabto.enabled = false;
                DieTimer = 0.5f;
            }
        }
    }
}