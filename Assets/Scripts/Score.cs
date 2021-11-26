using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameManager gameManager;
    public Transform player;
    public Text scoreText;
    public int scoreNum;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        //FindObjectOfType<Transform>();

        //scoreText.text = player.position.z.ToString("0");

        if (gameManager.gameHasEnded == true)
        {
            PlayerPrefs.DeleteAll();
            scoreText.text = "0";
        }
    }

    public void GainScoreCoin()
    {
        scoreNum = PlayerPrefs.GetInt("Score", 0);
        //int newScoreNum;
        int newScoreNum = scoreNum + 50;
        PlayerPrefs.SetInt("Score", newScoreNum);
        scoreText.text = newScoreNum.ToString();
    }



    //if (FindObjectOfType<GameManager>().gameHasEnded)

    //    {

    //        scoreText.text = "Game Over!";

    //    }
}
