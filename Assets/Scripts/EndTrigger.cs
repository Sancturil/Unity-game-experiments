using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerMovement movement;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            movement.enabled = false;
            gameManager.CompleteLevel();
        }

    }


}
