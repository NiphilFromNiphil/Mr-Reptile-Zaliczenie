using UnityEngine;

public class Detect : MonoBehaviour
{
    private float timer = 0.0f;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            timer = 0.1f;
        }
    }

    public bool IsGround()
    {
        if (timer > 0.0f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void FixedUpdate()
    {
        if (timer > 0.0f)
        {
            timer -= 0.017f;
            if (timer < 0.0f)
            {
                timer = 0.0f;
            }
        }
    }
}
