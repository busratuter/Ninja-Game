using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Text : MonoBehaviour
{

TextMeshProUGUI countdownText;
public int countdownTime = 20;
public GameObject panel;

void Start()
{

    countdownText = GameObject.Find("Canvas/countdownText").GetComponent<TextMeshProUGUI>();
    StartCoroutine(StartCountdown(countdownTime));
    
}

IEnumerator StartCountdown(int countdownTime)
{
    int countdownTimeInSeconds = countdownTime;
    NinjaController n1 = new NinjaController();

    while (countdownTimeInSeconds > 0)
    {
        
        countdownText.text = countdownTime + " seconds";
        yield return new WaitForSeconds(1);

        countdownTimeInSeconds--;
        countdownTime--;
    }

    countdownText.text = "you win!";
    panel.SetActive(true);
    Time.timeScale = 0.0f;
}

public void youLose(){
    countdownText.text = "you lose!";
}

public void TekrarOyna()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    Time.timeScale = 1.0f;
}

}