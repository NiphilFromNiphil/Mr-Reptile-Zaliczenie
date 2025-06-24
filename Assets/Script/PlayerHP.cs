using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float MaxHP;
    public Image HPBar;
    private float HP;
    public Transform DIE_UI;

    float DieTimer = 0.0f;

    private void Start()
    {
        HP = MaxHP;
    }

    private void FixedUpdate()
    {
        if (DieTimer > 0.0f)
        {
            DieTimer -= 0.017f;
            if (DieTimer <= 0.0f)
            {
                SceneManager.LoadScene("SampleScene");
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
                DieTimer = 0.5f;
            }
        }
    }
}