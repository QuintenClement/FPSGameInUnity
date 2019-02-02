using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAxeSounds : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] sounds;

    void PlaySound()
    {
        audioSource.clip = sounds[Random.Range(0, sounds.Length)];
        audioSource.Play();
    }
}
