using UnityEngine;
using TMPro; // Import for TextMeshPro

public class Point_manager : MonoBehaviour
{
    public static int points = 0;
    public TextMeshProUGUI PointText; 
    
    public void start()
    {
        UpdatePointText();
    }
    public void AddPoints(int value)
    {
        points += value;
        UpdatePointText();
    }

    private void UpdatePointText()
    {
        PointText.text = "Points: " + points.ToString();
    }
}
