using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        int[] casualArray = GeneraArray(10, 25, 500);

        StampaArray(casualArray);
        int minimoValoreArray = TrovaMinimo(casualArray);
        Debug.Log("il valore minimo del tuo array è " + minimoValoreArray);
        int massimoValoreArray = TrovaMassimo(casualArray);
        Debug.Log("il valore massimo del tuo array è " + massimoValoreArray);

        TrovaMinimo2(casualArray);
        TrovaMassimo2(casualArray);

    }

    // Update is called once per frame
    void Update()
    {

    }

    int[] GeneraArray(int dimensione, int valoreMinimo, int valoreMassimo)
    {

        int[] arrayProva = new int[dimensione];


        for (int i = 0; i < arrayProva.Length; i++)
        {
            arrayProva[i] = Random.Range(valoreMinimo, valoreMassimo + 1);
        }
        return arrayProva;

    }

    //public int SommaArray(int[] arrayInput)
    //{
    //    //Somma tutti i valori di un array
    //    if (arrayInput == null || arrayInput.Length == 0)
    //    {
    //        return 0;
    //    }
    //    int sommaCorrente = 0;
    //    foreach (int numero in arrayInput)
    //    {
    //        sommaCorrente += numero;
    //    }
    //    return sommaCorrente;

    //}

    public void StampaArray(int[] arrayDaStampare)
    {
        if (arrayDaStampare == null)
        {
            Debug.Log("Array nullo.");
            return;
        }
        string contenuto = "[";

        for (int i = 0; i < arrayDaStampare.Length; i++)
        {
            contenuto += arrayDaStampare[i];

            if (i < arrayDaStampare.Length - 1)
            {
                contenuto += ", ";
            }
        }
        contenuto += "]";
        Debug.Log(contenuto);
    }

    public int TrovaMinimo(int[] tuoArray)
    {
        int numMinimo = tuoArray[0];
        int numCorrente = 0;
        for (int i = 0; i < tuoArray.Length; i++)
        {
            numCorrente = tuoArray[i];
            if (numCorrente < numMinimo)
            {
                numMinimo = numCorrente;
            }


        }
        return numMinimo;
    }

    public int TrovaMassimo(int[] tuoArray)
    {
        int numMassimo = tuoArray[0];
        int numCorrente = 0;
        for (int i = 0; i < tuoArray.Length; i++)
        {
            numCorrente = tuoArray[i];
            if (numCorrente > numMassimo)
            {
                numMassimo = numCorrente;
            }


        }
        return numMassimo;
    }

    public void TrovaMinimo2(int[] tuoArray)
    {
        int numMinimo1 = tuoArray[0];
        int numMinimo2 = tuoArray[0];
        int numCorrente = 0;
        for (int i = 0; i < tuoArray.Length; i++)
        {
            numCorrente = tuoArray[i];
            if (numCorrente < numMinimo1)
            {
                numMinimo1 = numCorrente;
                
            }


        }

        numCorrente = 0;

        for (int i = 0; i < tuoArray.Length; i++)
        {
            numCorrente = tuoArray[i];
            if (numCorrente < numMinimo2 && numCorrente != numMinimo1)
            {
                numMinimo2 = numCorrente;
                
            }


        }
        Debug.Log("I due numeri più bassi sono: " + numMinimo1 + " e " + numMinimo2);

    }

    public void TrovaMassimo2(int[] tuoArray)
    {
        int numMassimo1 = tuoArray[0];
        int numMassimo2 = tuoArray[0];
        int numCorrente = 0;
        for (int i = 0; i < tuoArray.Length; i++)
        {
            numCorrente = tuoArray[i];
            if (numCorrente > numMassimo1)
            {
                numMassimo1 = numCorrente;
            }


        }
        numCorrente = 0;
        for (int i = 0; i < tuoArray.Length; i++)
        {
            numCorrente = tuoArray[i];
            if (numCorrente > numMassimo2 && numCorrente != numMassimo1)
            {
                numMassimo2 = numCorrente;
                
            }


        }
        Debug.Log("I due numeri più alti sono: " + numMassimo1 + " e " + numMassimo2);

    }


}
