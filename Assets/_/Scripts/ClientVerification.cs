using UnityEngine;

public class ClientVerification : MonoBehaviour
{
    [Header("Référence vers le Chaudron")]
    public Chaudron chaudronRef;

    // Fonction appelée lorsqu'interraction avec client
    public void InteragirAvecClient()
    {
        if (chaudronRef == null)
        {
            Debug.LogWarning("La référence vers le chaudron est manquante !");
            return;
        }

        // 1. Vérification potion verte
        if (chaudronRef.potionVerte)
        {
            Debug.Log("Le client reçoit la Potion Verte ! Merci !");

            // Mettez votre logique de succès ici (ex: donner des points, faire partir le client)

            // Remettre le chaudron vide
            ResetChaudronEtPotions();
        }
        // 2. Sinon, vérification échec
        else if (chaudronRef.potionEchec)
        {
            Debug.Log("Le client reçoit une potion ratée... Beurk !");

            // Mettez votre logique d'échec ici (ex: baisser la patience du client)

            // Remettre le chaudron vide
            ResetChaudronEtPotions();
        }
        else
        {
            Debug.Log("Le chaudron est vide ou aucune potion n'a été brassée !");
        }
    }

    // Après client prend potion, on remet les variables à false
    void ResetChaudronEtPotions()
    {
        // Cache les objets visuels des potions
        if (chaudronRef.VarPotionVerte != null) chaudronRef.VarPotionVerte.SetActive(false);
        if (chaudronRef.VarPotionEchec != null) chaudronRef.VarPotionEchec.SetActive(false);

        // Remet les booléens à false
        chaudronRef.potionVerte = false;
        chaudronRef.potionEchec = false;

        // Vide les slots d'ingrédients pour recommencer
        chaudronRef.slot1Rouge = false;
        chaudronRef.slot1Jaune = false;
        chaudronRef.slot1Bleu = false;
        chaudronRef.slot2Rouge = false;
        chaudronRef.slot2Jaune = false;
        chaudronRef.slot2Bleu = false;
    }
}