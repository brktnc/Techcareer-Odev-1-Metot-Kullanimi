using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odev1 : MonoBehaviour
{
    //3 adet değişken(int,float,string) kullanıp bu değişken türlerini 3 farklı metodun içerisinde kullanın.
    //1. Metotda int değişkenini if-else koşulu ile 2. Metotda float switch-case koşulu ile 3. Metotda string while döngüsü ile
    //kullanıp 3 metodu da başlangıçta çağırıp çalıştırmanızı istiyorum. Ve sonuçları console kısmında görmek istiyorum.
    int _variableInt = 5;
    float _variableFloat = 3.5f;
    String _variableString = "Hasar alindi, kalan can sayisi: ";
    void Start()
    {
        MethodwithInt(_variableInt);
        MethodwithFloat(_variableFloat);
        MethodwithString(_variableString);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void MethodwithInt(int var)
    {
        if (var > 0)
        {
            Debug.Log("Deger pozitif.");
        }else if (var == 0)
        {
            Debug.Log("Deger sifira esittir.");
        }
        else
        {
            Debug.Log("Deger negatiftir.");
        }
    }

    void MethodwithFloat(float var)
    {
        switch (var)
        {
            case 0.0f:
                Debug.Log("Karakter hareketsiz duruyor");
                break;
            case 3.5f:
                Debug.Log("Karakter yuruyor.");
                break;
            case 5.0f:
                Debug.Log("Karakter kosuyor.");
                break;
            default:
                Debug.Log("Farkli bir deger girisi HATA!");
                break;
        }
    }

    void MethodwithString(String var)
    {
        int hitCount = 3;
        while (hitCount > 0)
        {
            Debug.Log(var + hitCount);
            hitCount--;
        }
        Debug.Log("Öldün.");
    }
}
