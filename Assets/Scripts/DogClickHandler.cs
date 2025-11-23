using UnityEngine;
using UnityEngine.EventSystems;

public class DogClickHandler : MonoBehaviour, IPointerClickHandler
{
    private AudioSource audioSource;
    // Optional: If you want to use a different clip than the default on the AudioSource
    public AudioClip clickSound;

    void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Play the assigned sound
        if (audioSource != null)
        {
            if (clickSound != null)
            {
                audioSource.PlayOneShot(clickSound); // Use PlayOneShot for multiple clicks
            }
            else
            {
                audioSource.Play(); // Play the default clip assigned in the Inspector
            }
        }
    }
}

