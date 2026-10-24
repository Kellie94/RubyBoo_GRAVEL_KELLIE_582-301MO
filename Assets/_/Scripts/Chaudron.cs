using UnityEngine;

public class Chaudron : MonoBehaviour
{
    [Header("1. Ingrédients mis dans le chaudron (Slot 1)")]
    public bool slot1Rouge = false;
    public bool slot1Jaune = false;
    public bool slot1Bleu = false;

    [Header("1. Ingrédients mis dans le chaudron (Slot 2)")]
    public bool slot2Rouge = false;
    public bool slot2Jaune = false;
    public bool slot2Bleu = false;

    [Header("2. Résultats des potions (Booléens)")]
    public bool potionEchec = false;
    public bool potionVerte = false;

    // Fonction appelée par les boutons de l'UI pour remplir les slots
    public void PlacerIngredient(bool rouge, bool jaune, bool bleu)
    {
        // Si le Slot 1 est vide (aucun ingrédient n'y est encore vrai)
        if (!slot1Rouge && !slot1Jaune && !slot1Bleu)
        {
            slot1Rouge = rouge;
            slot1Jaune = jaune;
            slot1Bleu = bleu;
            Debug.Log("Ingrédient placé dans le Slot 1.");
        }
        // Sinon, si le Slot 2 est vide
        else if (!slot2Rouge && !slot2Jaune && !slot2Bleu)
        {
            slot2Rouge = rouge;
            slot2Jaune = jaune;
            slot2Bleu = bleu;
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

        // RECETTE : Potion Verte (Jaune + Bleu, peu importe l'ordre)
        if ((slot1Jaune && slot2Bleu) || (slot1Bleu && slot2Jaune))
        {
            potionVerte = true;
            Debug.Log("Ah! Est-ce que c'est la bonne potion? Succès");
        }
        // SI AUCUNE RECETTE NE CORRESPOND : Potion d'échec
        else
        {
            potionEchec = true;
            Debug.Log("Oh! Est-ce le bon mélange? Échec");
        }

        ViderChaudron();
    }

    void ResetPotions()
    {
        potionEchec = false;
        potionVerte = false;
    }

    void ViderChaudron()
    {
        slot1Rouge = false;
        slot1Jaune = false;
        slot1Bleu = false;
        slot2Rouge = false;
        slot2Jaune = false;
        slot2Bleu = false;
    }
}