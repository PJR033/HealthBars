using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;

    private Image _healthBar;

    private void Awake()
    {
        _healthBar = GetComponent<Image>();
    }

    private void OnEnable()
    {
        _health.HealthChanged += SetHealthBarValue;
    }

    private void OnDisable()
    {
        _health.HealthChanged -= SetHealthBarValue;
    }

    private void SetHealthBarValue()
    {
        float barValue = _health.CurrentHealth / _health.MaxHealth;

        _healthBar.fillAmount = barValue;
    }
}
