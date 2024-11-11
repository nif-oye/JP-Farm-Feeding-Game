using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 30f;
    float xPos = 20f;
    public GameObject projectilePrefab;
    void Start()
    {
        
    }
    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(horizontalInput, 0, 0);

        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -xPos, xPos);
        transform.position = clampedPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
