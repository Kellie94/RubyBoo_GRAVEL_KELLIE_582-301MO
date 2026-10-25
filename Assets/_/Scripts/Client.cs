using UnityEngine;

public class ReactionChaudron : MonoBehaviour
{
    [Header("Référence vers le Chaudron")]
    public Chaudron chaudronRef;

    void Update()
    {
        // Vérifie si le chaudron existe pour éviter les erreurs
        if (chaudronRef != null)
        {
            // Réaction si la potion verte est réussie
            if (chaudronRef.potionVerte == true)
            {
                Debug.Log("Le client a détecté la Potion Verte ! Je réagis !");

                // Mets ton action ici (ex: ouvrir une porte, lancer une animation, etc.)

                // Optionnel : remet à false si tu ne veux pas que ça tourne en boucle à chaque image
                chaudronRef.potionVerte = false; 
            }

            // Réaction si c'est un échec
            if (chaudronRef.potionEchec == true)
            {
                Debug.Log("Le client a détecté l'échec ! Aïe !");

                // Mets ton action d'échec ici (ex: faire tousser le personnage, enlever des points, etc.)

                chaudronRef.potionEchec = false;
            }
        }
    }
}