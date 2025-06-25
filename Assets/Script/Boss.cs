using System.Threading;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] private Enemy ENEMY_MOVEMENT;
    [SerializeField] private SpriteRenderer SPRITE_RENDERER;
    [SerializeField] private Sprite[] SPRITES;
    [SerializeField] private Animator FADE;
    [SerializeField] private float bosstime;
    [SerializeField] private GameObject text;
    int spritenum;
    float timerboss = 0.0f;
    float endgametimer = 0.0f;

    private void Start()
    {
        timerboss = bosstime;
    }
    private void Update()
    {
        SPRITE_RENDERER.sprite = SPRITES[spritenum];

        if (spritenum == 2)
        {
            ENEMY_MOVEMENT.SPEED = 0.04f;
        }
        if (spritenum == 3)
        {
            ENEMY_MOVEMENT.SPEED = 0.025f;
            text.SetActive(false);
        }
        if (spritenum == 4)
        {
            ENEMY_MOVEMENT.SPEED = 0.0f;
        }
    }
    private void FixedUpdate()
    {
        if (timerboss > 0.0f)
        {
            timerboss -= 0.017f;
            if (timerboss <= 0.0f)
            {
                spritenum++;
                if (spritenum < 6)
                {
                    timerboss = bosstime;
                }
                else
                {
                    timerboss = 0.0f;
                    endgametimer = 2.0f;
                }
            }
        }
        if (endgametimer > 0.0f)
        {
            endgametimer -= 0.017f;
            if (endgametimer <= 0.0f)
            {
                FADE.SetBool("Fade", true);
            }
        }
    }
}
