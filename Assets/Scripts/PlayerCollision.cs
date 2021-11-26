using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    

    private void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("We hit an obstacle.");
            //GetComponent<PlayerMovement>().enabled = false;
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }

        //if (collisionInfo.collider.tag == "END")
        //{
        //    //Debug.Log("We reached the end.");
        //    //GetComponent<PlayerMovement>().enabled = false;
        //    movement.enabled = false;
        //}

    }

}
