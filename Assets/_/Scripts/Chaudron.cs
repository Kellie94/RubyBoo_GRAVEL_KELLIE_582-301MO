using UnityEngine;

public class Chaudron : MonoBehaviour
{
    // 1. Déclaration des variables d'état
    public bool IngredientRouge = false;
    public bool IngredientJaune = false;
    public bool IngredientBleu = false;

    public bool potionEchec = false;
    public bool potionVerte = false;

    // 2. Fonction de vérification lorsqu'activé par l'input E dans le Event collider du Chaudron
    void VerifierCombinaison()
    {
        if (IngredientRouge)
        {
            potionEchec = true;
        }
        else if (IngredientJaune && IngredientBleu)
        {
            potionVerte = true;
        }
        else
        {
        }
    }

}
