using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    public float backwardForce = 1000f;

    public bool moveForward = false;
    public bool moveRight = false;
    public bool moveLeft = false;
    public bool moveBackward = false;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, World!");
        //rb.useGravity = false;
        rb.AddForce(0, 200, 500);
    }

    // Update is called once per frame 
    private void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            moveForward = true;
        }
        if (Input.GetKeyUp("w"))
        {
            moveForward = false;
        }

        if (Input.GetKeyDown("d"))
        {
            moveRight = true;
        }
        if (Input.GetKeyUp("d"))
        {
            moveRight = false;
        }

        if (Input.GetKeyDown("a"))
        {
            moveLeft = true;
        }
        if (Input.GetKeyUp("a"))
        {
            moveLeft = false;
        }

        if (Input.GetKeyDown("s"))
        {
            moveBackward = true;
        }
        if (Input.GetKeyUp("s"))
        {
            moveBackward = false;
        }
    }


    // Marked as "Fixed"Update because we're using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward Force on the z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if (moveForward)
        //{
        //    rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange); // Add a forward force on the z-axis based on player input
        //}

        if (moveRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // Add a (sideways) force on the x-axis based on player input
        }

        if (moveLeft)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // Add a (sideways) force on the x-axis in the opposite direction (negative) based on player input
        }

        if (moveBackward)
        {
            rb.AddForce(0, 0, -backwardForce * Time.deltaTime, ForceMode.VelocityChange); // Add a backward force on the z-axis based on player input
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
