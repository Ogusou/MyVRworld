using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ShowerController : UdonSharpBehaviour
{
    public ParticleSystem showerParticleSystem;
    private bool isShowerOn = false;

    void Start()
    {
        if (showerParticleSystem != null)
        {
            showerParticleSystem.Stop();
        }
    }

    public override void Interact()
    {
        Debug.Log("Button Pressed"); // デバッグログ
        if (showerParticleSystem != null)
        {
            if (isShowerOn)
            {
                showerParticleSystem.Stop();
                Debug.Log("Shower Off"); // デバッグログ
            }
            else
            {
                showerParticleSystem.Play();
                Debug.Log("Shower On"); // デバッグログ
            }
            
            isShowerOn = !isShowerOn;
        }
    }
}
