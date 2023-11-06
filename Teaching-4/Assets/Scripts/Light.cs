using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{

    public static int KBinput = 0;

    [SerializeField] private float speed = 3f;
    [SerializeField] private int num = 0;
    private Renderer rend;
    private Color originalColor;
    private bool isChanged = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    void Update()
    {
        if (num == 1 && KBinput == 1 ||
            num == 2 && KBinput == 2 ||
            num == 3 && KBinput == 3 ||
            num == 4 && KBinput == 4 ||
            num == 5 && KBinput == 5 ||
            num == 6 && KBinput == 6 ||
            num == 7 && KBinput == 7 ||
            num == 8 && KBinput == 8 ||
            num == 9 && KBinput == 9 ||
            num == 10 && KBinput == 10 ||
            num == 11 && KBinput == 11 ||
            num == 12 && KBinput == 12 ||
            num == 13 && KBinput == 13 ||
            num == 14 && KBinput == 14 ||
            num == 15 && KBinput == 15 ||
            num == 16 && KBinput == 16 ||
            num == 17 && KBinput == 17 ||
            num == 18 && KBinput == 18 ||
            num == 19 && KBinput == 19 ||
            num == 20 && KBinput == 20 ||
            num == 21 && KBinput == 21 ||
            num == 22 && KBinput == 22 ||
            num == 23 && KBinput == 23 ||
            num == 24 && KBinput == 24 ||
            num == 25 && KBinput == 25 ||
            num == 26 && KBinput == 26 ||
            num == 27 && KBinput == 27 ||
            num == 28 && KBinput == 28 ||
            num == 29 && KBinput == 29 ||
            num == 30 && KBinput == 30 ||
            num == 31 && KBinput == 31 ||
            num == 32 && KBinput == 32 ||
            num == 33 && KBinput == 33 ||
            num == 34 && KBinput == 34 ||
            num == 35 && KBinput == 35 ||
            num == 36 && KBinput == 36 ||
            num == 37 && KBinput == 37 


             )
        {

            isChanged = true;
            rend.material.color = Color.gray;

            KBinput = 0;
        }
        
        if (isChanged && rend.material.color != originalColor)
        {
            rend.material.color = Color.Lerp(rend.material.color, originalColor, speed *150*Time.deltaTime);
        }
        else
        {
            isChanged = false;
        }
    }

    
}
