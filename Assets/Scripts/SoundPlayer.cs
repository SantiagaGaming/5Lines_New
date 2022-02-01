using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip _tapButtonSound, _mapOpenSound,_mapCloseSound;
    private AudioSource _audioSource;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public void PlayTapSound()
    {
        _audioSource.PlayOneShot(_tapButtonSound);
    }
    public void PlayMapOpenSound()
    {
        _audioSource.PlayOneShot(_mapOpenSound);
    }
    public void PlayMapCloseSound()
    {
        _audioSource.PlayOneShot(_mapCloseSound);
    }

}
