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
        if (num == 0 && KBinput == 1 ||
            num == 1 && KBinput == 3 ||
            num == 2 && KBinput == 5 ||
            num == 3 && KBinput == 6 ||
            num == 4 && KBinput == 8 ||
            num == 5 && KBinput == 10 ||
            num == 6 && KBinput == 12 
            //num == 7 && Input.GetKeyDown(KeyCode.K) ||
            //num == 8 && Input.GetKeyDown(KeyCode.L) ||
            //num == 9 && Input.GetKeyDown(KeyCode.T) 

             )
        {
            isChanged = true;
            rend.material.color = Color.gray;

            KBinput = 0;
        }
        
        if (isChanged && rend.material.color != originalColor)
        {
            rend.material.color = Color.Lerp(rend.material.color, originalColor, speed * Time.deltaTime);
        }
        else
        {
            isChanged = false;
        }
    }
}
