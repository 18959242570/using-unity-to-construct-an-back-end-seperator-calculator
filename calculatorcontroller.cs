using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class calculatorcontroller : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro, textMeshPro1;

    private float memory, memory2, result = 0;
    private bool plus, minus, mul, devide,remainder,sin,cos = false;
    public int index = 1;
    public int i = 0;
    public void num1()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "1";
            textMeshPro1.text += "1";

        }
    }
    public void num2()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "2";
            textMeshPro1.text += "2";
        }
    }
    public void num3()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "3";
            textMeshPro1.text += "3";
        }
    }
    public void num4()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "4";
            textMeshPro1.text += "4";
        }
    }
    public void num5()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "5";
            textMeshPro1.text += "5";
        }
    }
    public void num6()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "6";
            textMeshPro1.text += "6";
        }
    }
    public void num7()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "7";
            textMeshPro1.text += "7";
        }
    }
    public void num8()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "8";
            textMeshPro1.text += "8";
        }
    }
    public void num9()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "9";
            textMeshPro1.text += "9";
        }
    }
    public void num0()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += "0";
            textMeshPro1.text += "0";
        }
    }
    public void numDOT()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text += ".";
            textMeshPro1.text += ".";
        }
    }
    public void numPLUS()
    {
        plus = true;
        textMeshPro1.text += "+";
    }
    public void numMINUS()
    {
        minus = true;
        textMeshPro1.text += "-";
    }
    public void numMUL()
    {
        mul = true;
        textMeshPro1.text += "*";
    }
    public void numDEVIDE()
    {
        devide = true;
        textMeshPro1.text += "/";
    }
    public void numREMINDER()
    {
        remainder = true;
        textMeshPro1.text += "%";
    }
    public void numSin()
    {
        sin = true;
        textMeshPro1.text += "sin";
    }
    public void numCos()
    {
        cos = true;
        textMeshPro1.text += "cos";
    }
    public void CLEARM()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text = null;
            memory2 = 0;
            memory = 0;
            textMeshPro1.text = null;
        }
    }
    public void CLEAR()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro.text = null;

        }
    }
    public void CLEAR0()
    {

        Debug.Log("在遮挡范围内");
        if (GameObject.FindGameObjectWithTag("Show"))
        {
            textMeshPro1.text = null;

        }
    }
    public void cal()
    {
        memory2 = float.Parse(textMeshPro.text);
        memory = memory2;
        CLEAR();

    }
    public void ent()
    {
        
        if (index <= 10)
        {
            memory2 = float.Parse(textMeshPro.text);
            if (plus == true)
            {
                textMeshPro1.text += "=";
                memory += memory2;
                Save(index.ToString(), textMeshPro1.text += memory.ToString());
                
                CLEAR0();
                index++;

                plus = false;
                
            }
            if (minus == true)
            {
                textMeshPro1.text += "=";
                
                memory -= memory2;
                Save(index.ToString(), textMeshPro1.text += memory.ToString());
                CLEAR0();
                index++;
                minus = false;
            }
            if (mul == true)
            {
                textMeshPro1.text += "=";
                
                memory *= memory2;
                Save(index.ToString(), textMeshPro1.text += memory.ToString());
                CLEAR0();
                index++;
                mul = false;
            }
            if (devide == true)
            {
                textMeshPro1.text += "=";
                
                memory /= memory2;
                Save(index.ToString(), textMeshPro1.text += memory.ToString());
                CLEAR0();
                index++;
                devide = false;
            }
            if (remainder == true)
            {
                textMeshPro1.text += "=";
                
                memory %= memory2;
                Save(index.ToString(), textMeshPro1.text += memory.ToString());
                CLEAR0();
                index++;
                devide = false;
            }
            if(sin ==true)
            {
                textMeshPro1.text += "=";
                memory = Mathf.Round(Mathf.Sin(memory2*Mathf.PI/180f)*100f)/100f;
                Save(index.ToString(), textMeshPro1.text += memory.ToString());
                CLEAR0();
                index++;
                sin = false;
            }
            if (cos == true)
            {
                textMeshPro1.text += "=";
                memory = Mathf.Round(Mathf.Cos(memory2 * Mathf.PI / 180f)*100f)/100f;
                Save(index.ToString(), textMeshPro1.text += memory.ToString());
                CLEAR0();
                index++;
                cos = false;
            }
            Debug.Log(index);
            textMeshPro.text = memory.ToString();
            
        }
        if (index == 10)
        {
            index = 0;
        }
    }
    public void Save(string formula, string result) 
    {    
        PlayerPrefs.SetString(formula,result);
        PlayerPrefs.Save();
    }
    public void Ans()
    {
        string[] ansfind = { "1","2","3","4","5","6","7","8","9","10"};
        
        if (PlayerPrefs.HasKey(ansfind[i]))
        {
            textMeshPro.text = PlayerPrefs.GetString(ansfind[i]);
            i++;
            Debug.Log(i);
        }
        
        if (i == 9)
        {
            i = 0;
        }
        
        
    }
    public void AnsClear()
    {
        CLEAR();
        PlayerPrefs.DeleteAll();
    }
}

