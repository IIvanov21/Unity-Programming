using UnityEngine;
using UnityEngine.Events;

public class InteractionExample : MonoBehaviour
{
    public InputReader inputReader;
    public UnityEvent interactionEvent;
    public ParticleSystem particleSystem;

    private void Awake()
    {
        //inputReader.AttackEvent += EnableParticleSystem;
    }

    private void OnDestroy()
    {
        //inputReader.AttackEvent -= EnableParticleSystem;
    }

    void EnableParticleSystem()
    {
        particleSystem.Play();
    }
}
