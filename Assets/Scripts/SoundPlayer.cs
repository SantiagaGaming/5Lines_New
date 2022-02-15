using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip _tapButtonSound, _mapOpenSound, _mapCloseSound, _radioSound, _stoneSound;

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
    public void PlayRadioSound()
    {
        _audioSource.PlayOneShot(_radioSound);
    }
    public void PlayStoneSound()
    {
        _audioSource.PlayOneShot(_stoneSound);
    }
}
