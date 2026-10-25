using UnityEngine;

public class BoutonIngredient : MonoBehaviour
{
    [Header("Référence au Chaudron")]
    public Chaudron chaudron;

    [Header("Quel est cet ingrédient ?")]
    public bool estRouge = false;
    public bool estJaune = false;
    public bool estBleu = false;

    // Lié à la fonction OnClick() du bouton dans l'UI
    public void OnClickBouton()
    {
        if (chaudron == null)
        {
            Debug.LogWarning("Je n'ai rien mis dans le chaudron!");
            return;
        }

        // Envoie l'ingrédient cliqué au chaudron
        chaudron.PlacerIngredient(estRouge, estJaune, estBleu);
    }
}