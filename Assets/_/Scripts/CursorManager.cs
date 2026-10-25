using StarterAssets;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [Header("Mettre le PlayerArmature")]
    public StarterAssetsInputs starterAssetsInputs;

    // Appeler quand le joueur appuie E sur trigger Chaudron
    public void AfficherCurseur()
    {
        Cursor.visible = true;                  // Rend le curseur visible
        Cursor.lockState = CursorLockMode.None; // Libère le curseur pour qu'il puisse bouger librement sur l'écran

        if (starterAssetsInputs != null)
        {
            starterAssetsInputs.cursorInputForLook = false; // Désactive la rotation par la souris
        }
    }

    // Appeler cette fonction quand le joueur appuie sur le bouton Mélanger pour fermer le menu
    public void MasquerCurseur()
    {
        Cursor.visible = false;                     // Cache le curseur
        Cursor.lockState = CursorLockMode.Locked;   // Bloque le curseur au centre de l'écran

        if (starterAssetsInputs != null)
        {
            starterAssetsInputs.cursorInputForLook = true; // Réactive la rotation par la souris
        }
    }
}