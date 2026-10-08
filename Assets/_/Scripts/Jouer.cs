using UnityEngine;
using UnityEngine.SceneManagement;

public class Jouer : MonoBehaviour
{
    public void GotoSceneApothicaire()
    {
        SceneManager.LoadScene("Apothicaire");
    }
}
