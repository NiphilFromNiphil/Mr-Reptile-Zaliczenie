using Unity.VisualScripting;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
    [SerializeField] private float DAMAGE;
    private PlayerHP playerHP;

    private void Start()
    {
        playerHP = GameObject.FindGameObjectWithTag("PlayerHP").GetComponent<PlayerHP>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerHP")
        {
            playerHP.Hit(DAMAGE);
        }
    }
}
