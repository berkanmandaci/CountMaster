using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomScore : MonoBehaviour
{
    public int scoreValue;

    public TextMeshProUGUI scoreValueText;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = Random.Range(10, 20);
        scoreValueText.text = "+" + scoreValue;
    }

    // Update is called once per frame
  
}
