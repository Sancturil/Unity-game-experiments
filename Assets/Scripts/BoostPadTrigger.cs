using UnityEngine;

public class BoostPadTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement movement;

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            movement.rb.AddForce(0, 0, 15000);
            
        }
    }



}
