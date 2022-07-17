using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoregenerator1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        scoremodifier1.score ++;
        Debug.Log(scoremodifier1.score);
    }
}
