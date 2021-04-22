using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health_Bars : MonoBehaviour
{
    public Slider playerHealthBar;
    public Slider enemyHealthBar;

    public Image playerImg;

    public Image enemyImg;

    public float eCurrentHealth;
    private float eMaxHealth =30f;

    public float pCurrentHealth;
    public float pMaxHealth = 30f;

    public Player_Controller player_Controller;
    public Enemy_AI enemy_AI;

    void Start()
    {
        enemyImg.GetComponent<Image>();
        playerImg.GetComponent<Image>();
    }

    
    void Update()
    {
        eCurrentHealth = enemy_AI.enemyCurrentHealth;
        enemyImg.fillAmount = eCurrentHealth / eMaxHealth;

        pCurrentHealth = player_Controller.playerCurrentHealth;
        playerImg.fillAmount = pCurrentHealth/pMaxHealth;
    }
}
