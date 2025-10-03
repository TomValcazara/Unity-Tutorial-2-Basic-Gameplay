using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    private float speed = 30.0f;
    private float xRange = 16;
    //public GameObject projectilePrefab;
    public GameObject[] projectilePrefabList;
    private int randomFoodIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            randomFoodIndex = Random.Range(0, 3);
            Instantiate(projectilePrefabList[randomFoodIndex], transform.position, projectilePrefabList[randomFoodIndex].transform.rotation);
        }
    }
}
