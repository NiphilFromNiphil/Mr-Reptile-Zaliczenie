using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float MOVE_SPEED;
    [SerializeField] private Rigidbody2D RB;
    [SerializeField] private Detect DETECT;
    [SerializeField] private float JUMP_FORCE;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (DETECT.IsGround())
            {
                RB.linearVelocityY = 0.0f;
                RB.AddForce(new Vector2(0.0f, JUMP_FORCE));
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            RB.transform.rotation = Quaternion.Euler(0, 180, 0);
            RB.linearVelocityX = -MOVE_SPEED;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RB.transform.rotation = Quaternion.Euler(0, 0, 0);
            RB.linearVelocityX = MOVE_SPEED;
        }
        else
        {
            RB.linearVelocityX = 0.0f;
        }
    }
}
