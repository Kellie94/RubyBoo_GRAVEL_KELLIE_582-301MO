using UnityEngine;

public class BoutonIngredient : MonoBehaviour
{
    [Header("Référence au Chaudron")]
    public Chaudron chaudron;

    [Header("Quel est cet ingrédient ?")]

    // Niveau 1

    public bool estRouge = false;
    public bool estJaune = false;
    public bool estBleu = false;

    // Niveau 2
    public bool estChampignonMauve = false;
    public bool estFleurMauve = false;
    public bool estCitrouille = false;


    // Niveau 3
    public bool estChampignonOrange = false;
    public bool estplaceholder = false;
    public bool estplacehorlder2 = false;


    // Lié à la fonction OnClick() du bouton dans l'UI
    public void OnClickBouton()
    {
        if (chaudron == null)
        {
            Debug.LogWarning("Je n'ai rien mis dans le chaudron!");
            return;
        }

        // Envoie l'ingrédient cliqué au chaudron
        chaudron.PlacerIngredient(estRouge, estJaune, estBleu, estChampignonMauve, estFleurMauve, estCitrouille, estChampignonOrange, estplaceholder, estplacehorlder2);
    }
}