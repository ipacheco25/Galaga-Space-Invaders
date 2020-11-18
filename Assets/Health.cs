using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Player player;
    public Text healthText;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + player.health.ToString();
        
    }
}
