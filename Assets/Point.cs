using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Point : MonoBehaviour
{
    float points= 0;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
   void Start() {
        scoreText.text= "0";
    }
   public void AddPoints(){
    points++;
    scoreText.text =points.ToString();
   }
}
