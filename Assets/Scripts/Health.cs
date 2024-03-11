using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action HealthChanged;
    public event Action HealthOver;

    public float MaxHealth { get; private set; } = 100;
    public float CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(float dealedDamage)
    {
        if (dealedDamage >= 0)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth - dealedDamage, 0, MaxHealth);
            HealthChanged?.Invoke();

            if (CurrentHealth == 0)
            {
                HealthOver?.Invoke();
            }
        }
    }

    public void TakeHeal(float healthHealed)
    {
        if (healthHealed >= 0)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth + healthHealed, 0, MaxHealth);
            HealthChanged?.Invoke();
        }
    }
}
