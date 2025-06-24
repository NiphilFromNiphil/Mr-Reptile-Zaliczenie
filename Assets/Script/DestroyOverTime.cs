using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{
    [SerializeField] private float time;
    void FixedUpdate()
    {
        if (time > 0.0f)
        {
            time -= 0.017f;
            if (time <= 0.0f)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
