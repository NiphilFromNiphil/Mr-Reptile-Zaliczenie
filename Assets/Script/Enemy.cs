using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform PARENT;
    [SerializeField] private float SPEED;
    [SerializeField] private Transform POINT1;
    [SerializeField] private Transform POINT2;

    private float prog = 0.0f;
    private bool on;


    private void Update()
    {
        PARENT.transform.position = new Vector2(Vector2.Lerp(POINT1.position,POINT2.position, prog).x, PARENT.transform.position.y);
    }

    private void FixedUpdate()
    {
        if (prog < 1.0f && on == true)
        {
            prog += 0.017f * SPEED;
        }
        else
        {
            on = false;
        }

        if (prog > 0.0f && on == false)
        {
            prog -= 0.017f * SPEED;
        }
        else
        {
            on = true;
        }
    }
}
