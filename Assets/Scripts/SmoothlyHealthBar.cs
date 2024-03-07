using UnityEngine.UI;
using UnityEngine;

public class SmoothlyHealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private float _maxDelta;

    private Image _healthBar;

    private void Awake()
    {
        _healthBar = GetComponent<Image>();
    }

    private void Update()
    {
        SetHealthBarValueSmoothly();
    }

    private void SetHealthBarValueSmoothly()
    {
        float barValue = _health.CurrentHealth / _health.MaxHealth;

        _healthBar.fillAmount = Mathf.MoveTowards(_healthBar.fillAmount, barValue, _maxDelta);
    }
}
