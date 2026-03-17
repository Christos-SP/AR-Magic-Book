using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource myAudio;

    public void ToggleMute()
    {
        myAudio.mute = !myAudio.mute; // Αν είναι mute το ξε-μουτάρει και το αντίστροφο
    }
}
