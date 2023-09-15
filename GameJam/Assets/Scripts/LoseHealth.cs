using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LoseHealth : MonoBehaviour
{

    public GameObject[] health;
    public static int amount;

    private void Start()
    {
        amount = health.Length;
        StartCoroutine(Damage());
    }

    private void Update()
    {
        if (amount <= 0)
        {
            //exit scene
        }
    }

    IEnumerator Damage()
    {
        while (true)
        {
            loseHealth();
            yield return new WaitForSeconds(1);
        }
    }

    void loseHealth()
    {
        health[amount - 1].SetActive(false);
        amount -= 1;
    }
}
