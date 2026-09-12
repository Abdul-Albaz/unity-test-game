using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombDefuseing : MonoBehaviour
{
    public bool playerIsIntheArea = false;
    public bool isDefuseing = false;
    Coroutine coroutine;
    public GameObject bomb;
  
    void Start()
    {
        
        coroutine = StartCoroutine(DefusingBoomb());
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && playerIsIntheArea && !isDefuseing)
        {  
            Debug.Log("Defusing");
            StartCoroutine(DefusingBoomb());
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        playerIsIntheArea = true;      

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Inside the Area");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player OutSide the Area");
        }

        StopDefusing();

    }


    IEnumerator DefusingBoomb()
    {
        isDefuseing = true;
        int timer = 2;

        Debug.Log("Defusing start");
        while (timer > 0)
        {
            yield return new WaitForSeconds(2f);
            timer--;
        }
       

        Debug.Log("Bomb Defused ");
        bomb.SetActive(false);
       

    }

    void StopDefusing()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
        isDefuseing = false;
    }





    IEnumerator LoadasyncLevel()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("level2");

        while (!asyncOperation.isDone)
        {
            Debug.Log("loding progress" + asyncOperation.progress);
            yield return null;
        }

        
    }

   
}
