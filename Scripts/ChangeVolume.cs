using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVolume : MonoBehaviour
{
  private AudioSource audioSrc;
  private float nowVol = 1f;

  private void Start()
  {
    audioSrc = GetComponent<AudioSource>();
  }

  private void Update()
  {
    audioSrc.volume = nowVol;
  }

  public void SetVolume(float vol)
  {
    nowVol = vol;
  }
}
