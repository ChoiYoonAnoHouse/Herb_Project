using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI brainText;
    public TextMeshProUGUI allureText;
    public TextMeshProUGUI moralText;
    public TextMeshProUGUI feelText;
    public TextMeshProUGUI talkText;
    public TextMeshProUGUI happyText;
    public TextMeshProUGUI societyText;
    public TextMeshProUGUI stressText;
    private int money;
    private int hp;
    private int brain;
    private int allure;
    private int moral;
    private int feel;
    private int talk;
    private int happy;
    private int society;
    private int stress;

    // Start is called before the first frame update
    void Start()
    {
        money = 10000;
        moneyText.text = "Money : " + money;
        hp = 100;
        hpText.text = " " + hp;
        brain = 10;
        brainText.text = " " + brain;
        allure = 0;
        allureText.text = " " + allure;
        moral = 0;
        moralText.text = " " + moral;
        feel = 0;
        feelText.text = " " + feel;
        talk = 10;
        talkText.text = " " + talk;
        happy = 5;
        happyText.text = " " + happy;
        society = 0;
        societyText.text = " " + society;
        stress = 0;
        stressText.text = " " + stress;

    }

    public void UpdateScore(int scoreToAdd)
    {
        

    }
}
