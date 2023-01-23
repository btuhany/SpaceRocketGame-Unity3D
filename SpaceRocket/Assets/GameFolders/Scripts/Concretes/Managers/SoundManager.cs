using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class SoundManager : SingletonObject<SoundManager>
    {
        AudioSource[] _audioSource;
        private void Awake()
        {
            SingletonThisGameObject(this);
            _audioSource = GetComponentsInChildren<AudioSource>();
        }
        public void PlaySound(int index)
        {
            if (!_audioSource[index].isPlaying)
                _audioSource[index].Play();
        }
        public void StopSound(int index)
        {
            if (_audioSource[index].isPlaying)
                _audioSource[index].Stop();
        }
        public void SetVolume(int index,float newVolume)
        {
            _audioSource[index].volume = newVolume;
        }
        public void StopAllSounds()
        {
            foreach(var audio in _audioSource)
            audio.Stop();
        }
        public void PlaySoundWithDelay(int index, float delay)
        {
            if (!_audioSource[index].isPlaying)
                _audioSource[index].PlayDelayed(delay);
        }
    }
}

