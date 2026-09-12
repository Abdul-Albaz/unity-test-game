using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class BombDefuse : MonoBehaviour
{
    public int countdownTime = 3;
    public Text countdownText;

  
    public GameState currentState = GameState.Playing;

    bool playerInside = false;
    bool isDefusing = false;
    Coroutine defuseCoroutine;

    void Update()
    {
        if (playerInside && !isDefusing && Input.GetKeyDown(KeyCode.E))
        {
          
            defuseCoroutine = StartCoroutine(DefuseCountdown());

            currentState = GameState.Defusing;
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            countdownText.text = "Press E to defuse"; 

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            StopDefuse();


            currentState = GameState.Playing;
        }
    }

    IEnumerator DefuseCountdown()
    {
        isDefusing = true;
        int timeLeft = countdownTime;

        while (timeLeft > 0)
        {
            countdownText.text = "Defusing: " + timeLeft;
            yield return new WaitForSeconds(1f);

            if (!playerInside) 
                yield break;

            timeLeft--;
        }

        countdownText.text = "Bomb Defused!";
       
        yield return new WaitForSeconds(1f);
        
        gameObject.SetActive(false);

       
        //SceneManager.LoadScene(0);

        countdownText.text = "";


        currentState = GameState.GameOver;
    }

    void StopDefuse()
    {
        if (defuseCoroutine != null)
            StopCoroutine(defuseCoroutine);

        isDefusing = false;
        countdownText.text = "";
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }



}