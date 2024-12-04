
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Potato : UdonSharpBehaviour
{
    public GameObject dish;
    private AudioSource audioSource;
  
void Start()
{
    audioSource=GetComponent<AudioSource>();
}


public override void Interact()
{
    audioSource.Play();
}
void OnDrop() {
    //   audioSource.Play();
  gameObject.transform.position = dish.transform.position + new Vector3(0, 0.05f, 0);
//   audioSource.Play();
}
}
