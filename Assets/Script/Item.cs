using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int ID;
    Inventory inventory;
    bool cooldown;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerHP")
        {
            if (cooldown == false)
            {
                inventory.AddItem(ID);
                Destroy(this.gameObject);
                cooldown = true;
            }
        }
    }
}
