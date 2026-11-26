using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void GotoSceneGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}