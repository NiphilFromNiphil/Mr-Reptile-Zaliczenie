using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float MOVE_SPEED;
    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private Detect DETECT;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (DETECT.IsGround())
            {
                RB.AddForce(new Vector2(0.0f, JUMP));
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            RB.linearVelocityX = -MOVE_SPEED;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RB.linearVelocityX = MOVE_SPEED;
        }
        else
        {
            RB.linearVelocityX = 0.0f;
        }
    }
}
