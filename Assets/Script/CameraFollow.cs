using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform PARENT;
    [SerializeField] private Vector2 OFFSET;
    private PlayerController PLAYER;
    private void Start()
    {
        PLAYER = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        PARENT.position = new Vector3(PLAYER.transform.position.x + OFFSET.x, PLAYER.transform.position.y + OFFSET.y, -10.0f);
    }
}