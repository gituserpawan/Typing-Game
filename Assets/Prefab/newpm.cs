using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class newpm : MonoBehaviour
{
   public TextMeshProUGUI PointText;

    private void Start()
    {
        // Display the points in the new scene
        if (PointText != null)
        {
            PointText.text = "Points: " + Point_manager.points.ToString();
        }
    }
}



