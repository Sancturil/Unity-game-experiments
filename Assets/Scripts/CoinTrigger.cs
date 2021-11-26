using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public MeshRenderer coinVisibility;
    public Score score;

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            coinVisibility.enabled = false;
            score.GainScoreCoin();
        }
    }





}
