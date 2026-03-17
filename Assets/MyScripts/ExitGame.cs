using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void QuitApp()
    {
        // Κλείνει την εφαρμογή
        Application.Quit();

        // Επειδή το Quit δεν δουλεύει μέσα στο Unity Editor, 
        // προσθέτουμε αυτό για να βλέπουμε ότι πατήθηκε:
        Debug.Log("Η εφαρμογή έκλεισε!");
    }
}
