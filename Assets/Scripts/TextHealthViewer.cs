using UnityEngine;
using TMPro;

public class TextHealthViewer : MonoBehaviour
{
    [SerializeField] private Health _health;

    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        ViewHealth();
    }

    private void ViewHealth()
    {
        string currentHealth = _health.CurrentHealth.ToString();
        string maxHealth = _health.MaxHealth.ToString();

        _text.text = $"Health - {currentHealth}/{maxHealth}";
    }
}
