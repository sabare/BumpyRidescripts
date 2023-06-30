using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdate : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text life_text;
    public int life = 4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life_text.text = "Life:"+ life;
    }
}
