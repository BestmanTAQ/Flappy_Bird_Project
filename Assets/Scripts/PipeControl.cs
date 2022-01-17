using UnityEngine;

public class PipeControl : MonoBehaviour
{
    [SerializeField] private float speedX;
    private int pointDestroy = -4;
  
    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speedX;

        if(transform.position.x < pointDestroy)
        {
            Destroy(gameObject);
        }
    }
}