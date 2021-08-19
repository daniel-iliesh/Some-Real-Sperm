using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    private void Update() {
        scoreText.text = player.position.z.ToString("0");
    }
}
