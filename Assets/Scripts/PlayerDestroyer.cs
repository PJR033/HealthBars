using UnityEngine;

[RequireComponent(typeof(Health))]
public class PlayerDestroyer : MonoBehaviour
{
    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    private void OnEnable()
    {
        _health.HealthOver += DestoryPlayer;
    }

    private void OnDisable()
    {
        _health.HealthOver -= DestoryPlayer;
    }

    private void DestoryPlayer()
    {
        Destroy(gameObject);
    }
}