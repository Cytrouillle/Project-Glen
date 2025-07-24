using UnityEngine;

public class UnderwaterAudioTrigger : MonoBehaviour
{
    public Transform waterSurface;             // Reference to the water plane
    public AudioSource underwaterAudioSource;  // AudioSource on the water object
    public Transform cameraTarget;             // Your player's camera target (head height)

    private bool isUnderwater = false;

    void Update()
    {
        float waterY = waterSurface.position.y;
        float headY = cameraTarget.position.y;

        if (headY < waterY && !isUnderwater)
        {
            underwaterAudioSource.Play();
            isUnderwater = true;
        }
        else if (headY >= waterY && isUnderwater)
        {
            underwaterAudioSource.Stop();
            isUnderwater = false;
        }
    }
}
