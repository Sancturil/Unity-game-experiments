using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LevelSelectMenu()
    {
        SceneManager.LoadScene("TracksMenu");
    }

    public void LoadLevel01()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LoadLevel02()
    {
        SceneManager.LoadScene("Level02");
    }

    public void LoadLevel03()
    {
        SceneManager.LoadScene("Level03");
    }

    public void LoadLevel04()
    {
        SceneManager.LoadScene("Level04");
    }

}
