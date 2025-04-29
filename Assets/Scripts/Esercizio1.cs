using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int numero = 6;
    public int nbase = 5;
    public int multiple = 15;
    // Start is called before the first frame update
    void Start()
    {
        bool risultato;
        risultato = IsEven(numero);
        if (risultato)
        {
            Debug.Log("il numero " + numero + " è pari");
        }
        Debug.Log("il numero " + numero + " è dispari");

        bool risultato2;
        risultato2 = IsMultiple(nbase, multiple);

        if (risultato2)
        {
            Debug.Log("il numero " + nbase + " è multiplo di " + multiple);
        }
        Debug.Log("il numero " + nbase + " non è multiplo di " + multiple);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool IsEven(int number)
    {
        if (number % 2 == 0) { 
        return true;
        }
        return false;
    }

    bool IsMultiple(int nbase, int multiple)
    {
        for (int i = 0; i <= nbase; i++)
        {
            if (nbase * (i + 1) == multiple)
            {
                return true;
            }
            

        }
        return false;
    }
}
