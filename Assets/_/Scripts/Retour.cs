using UnityEngine;
using UnityEngine.SceneManagement;

public class Retour : MonoBehaviour
{
    public void GotoSceneAccueil()
    {
        SceneManager.LoadScene("Accueil");
    }
}
