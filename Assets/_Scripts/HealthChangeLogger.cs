using UnityEngine;

public class HealthChangeLogger : MonoBehaviour 
{
    private void OnEnable()
    {
        Player.OnHealthChange += LogNewHealth;
    }

    private void OnDisable()
    {
        Player.OnHealthChange -= LogNewHealth;
    }

    public void LogNewHealth(float health)
    {
        // 1 decimal place
        string healthAsString = health.ToString("0.0");
        Debug.Log("health = " + healthAsString);
    }
}
