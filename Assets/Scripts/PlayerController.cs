using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private float forñe = 4f;
    private float topBorder = 4.8f;
    private float gravity = 9.81f;
    private Vector3 direction;

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;

        direction = Vector3.zero;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * forñe;
        }

        direction.y -= gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        if (transform.position.y >= topBorder)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

     private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}