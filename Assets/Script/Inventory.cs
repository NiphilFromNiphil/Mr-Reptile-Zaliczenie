using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private int[] FRUIT_AMOUNT;
    [SerializeField] private Image[] ICONS;
    [SerializeField] private Sprite DISABLED_SPRITE;
    [SerializeField] private Sprite[] ENABLED_SPRITES;
    [SerializeField] private TextMeshProUGUI[] TEXT_VALUES;
    [SerializeField] private Transform[] EXPLOSIONS;
    [SerializeField] private Transform EXPLOSION_SPAWN;

    public void AddItem(int id)
    {
        FRUIT_AMOUNT[id]++;
    }
    void UseItem(int id)
    {
        if (FRUIT_AMOUNT[id] > 0)
        {
            FRUIT_AMOUNT[id]--;
            Instantiate(EXPLOSIONS[id], EXPLOSION_SPAWN.position, EXPLOSION_SPAWN.rotation);
        }
    }
    private void Update()
    {
        for (int i = 0; i < FRUIT_AMOUNT.Length; i++)
        {
            if (FRUIT_AMOUNT[i] <= 0)
            {
                ICONS[i].sprite = DISABLED_SPRITE;
            }
            else
            {
                ICONS[i].sprite = ENABLED_SPRITES[i];
            }

            TEXT_VALUES[i].text = FRUIT_AMOUNT[i].ToString();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UseItem(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UseItem(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            UseItem(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            UseItem(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            UseItem(4);
        }
    }
}