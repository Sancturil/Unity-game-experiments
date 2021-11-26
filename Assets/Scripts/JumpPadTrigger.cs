using UnityEngine;

public class JumpPadTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement movement;

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            movement.rb.AddForce(0, 2500, 4000);

        }
    }




}
