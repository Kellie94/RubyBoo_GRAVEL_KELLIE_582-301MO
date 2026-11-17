using UnityEngine;

public class Chaudron : MonoBehaviour
{
    [Header("1. Ingrédients mis dans le chaudron (Slot 1)")]

    // Niveau 1
    public bool slot1Rouge = false;
    public bool slot1Jaune = false;
    public bool slot1Bleu = false;

    // Niveau 2
    public bool slot1ChampignonMauve = false;
    public bool slot1FleurMauve = false;
    public bool slot1Citrouille = false;

    // Niveau 3
    public bool slot1ChampignonOrange = false;
    public bool slot1Placeholder = false;
    public bool slot1Placeholder2 = false;

    [Header("1. Ingrédients mis dans le chaudron (Slot 2)")]

    // Niveau 1
    public bool slot2Rouge = false;
    public bool slot2Jaune = false;
    public bool slot2Bleu = false;

    // Niveau 2
    public bool slot2ChampignonMauve = false;
    public bool slot2FleurMauve = false;
    public bool slot2Citrouille = false;

    // Niveau 3
    public bool slot2ChampignonOrange = false;
    public bool slot2Placeholder = false;
    public bool slot2Placeholder2 = false;

    // Résultat de la potion

    [Header("2. Résultats des potions (Booléens)")]
    public bool potionEchec = false;
    public bool potionVerte = false;

    [Header("2. Les variables des potions")]
    public GameObject VarPotionVerte;
    public GameObject VarPotionEchec;

    // Permet le on click() des boutons ingrédients et récupérer la valeur de la variable

    // Niveau 1
    public void AjouterRouge()
    {
        PlacerIngredient(true, false, false, false, false, false, false, false, false);
    }

    public void AjouterJaune()
    {
        PlacerIngredient(false, true, false, false, false, false, false, false, false);
    }

    public void AjouterBleu()
    {
        PlacerIngredient(false, false, true, false, false, false, false, false, false);
    }

    // Niveau 2
    public void AjouterChampignonMauve()
    {
        PlacerIngredient(false, false, false, true, false, false, false, false, false);
    }

    public void AjouterFleurMauve()
    {
        PlacerIngredient(false, false, false, false, true, false, false, false, false);
    }

    public void AjouterCitrouille()
    {
        PlacerIngredient(false, false, false, false, false, true, false, false, false);
    }

    // Niveau 3
    public void AjouterChampignonOrange()
    {
        PlacerIngredient(false, false, false, false, false, false, true, false, false);
    }

    public void AjouterPlaceholder()
    {
        PlacerIngredient(false, false, false, false, false, false, false, true, false);
    }

    public void AjouterPlaceholder2()
    {
        PlacerIngredient(false, false, false, false, false, false, false, false, true);
    }

    // Fonction appelée par les boutons de l'UI pour remplir les slots
    public void PlacerIngredient(bool rouge, bool jaune, bool bleu, bool champignonMauve, bool fleurMauve, bool citrouille, bool champignonOrange, bool placeholder, bool placeholder2)
    {
        // Vérifie si le Slot 1 est complètement vide
        bool slot1EstVide = !slot1Rouge && !slot1Jaune && !slot1Bleu &&
                            !slot1ChampignonMauve && !slot1FleurMauve && !slot1Citrouille &&
                            !slot1ChampignonOrange && !slot1Placeholder && !slot1Placeholder2;

        // Vérifie si le Slot 2 est complètement vide
        bool slot2EstVide = !slot2Rouge && !slot2Jaune && !slot2Bleu &&
                            !slot2ChampignonMauve && !slot2FleurMauve && !slot2Citrouille &&
                            !slot2ChampignonOrange && !slot2Placeholder && !slot2Placeholder2;

        // Si le Slot 1 est vide
        if (slot1EstVide)
        {
            slot1Rouge = rouge;
            slot1Jaune = jaune;
            slot1Bleu = bleu;
            slot1ChampignonMauve = champignonMauve;
            slot1FleurMauve = fleurMauve;
            slot1Citrouille = citrouille;
            slot1ChampignonOrange = champignonOrange;
            slot1Placeholder = placeholder;
            slot1Placeholder2 = placeholder2;

            Debug.Log("Ingrédient placé dans le Slot 1.");
        }
        // Sinon, si le Slot 2 est vide
        else if (slot2EstVide)
        {
            slot2Rouge = rouge;
            slot2Jaune = jaune;
            slot2Bleu = bleu;
            slot2ChampignonMauve = champignonMauve;
            slot2FleurMauve = fleurMauve;
            slot2Citrouille = citrouille;
            slot2ChampignonOrange = champignonOrange;
            slot2Placeholder = placeholder;
            slot2Placeholder2 = placeholder2;

            Debug.Log("Ingrédient placé dans le Slot 2. Chaudron plein !");
        }
        else
        {
            Debug.Log("Le chaudron a déjà ses 2 ingrédients maximums !");
        }
    }

    // Fonction liée au bouton UI qui procède à la vérification
    public void LancerVerification()
    {
        VerifierCombinaison();
    }

    void VerifierCombinaison()
    {
        ResetPotions();

        // RECETTE : Potion Verte (Jaune + Bleu, Champignon Mauve + Fleur Mauve, ou Champignon Orange + Placeholder)
        if ((slot1Jaune && slot2Bleu) || (slot1Bleu && slot2Jaune) ||
            (slot1ChampignonMauve && slot2FleurMauve) || (slot1FleurMauve && slot2ChampignonMauve) ||
            (slot1ChampignonOrange && slot2Placeholder) || (slot1Placeholder && slot2ChampignonOrange))
        {
            potionVerte = true;
            Debug.Log("Ah! Est-ce que c'est la bonne potion? Succès");

            // Change la variable Potion Succès à TRUE
            if (VarPotionVerte != null)
            {
                VarPotionVerte.SetActive(true);
            }
        }
        // SI AUCUNE RECETTE NE CORRESPOND : Potion d'échec
        else
        {
            potionEchec = true;
            Debug.Log("Oh! Est-ce le bon mélange? Échec");
            if (VarPotionEchec != null)
            {
                VarPotionEchec.SetActive(true);
            }
        }
    }

    void ResetPotions()
    {
        potionEchec = false;
        potionVerte = false;
    }
}
