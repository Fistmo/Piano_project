using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Image timer_image;
    public float image_width = 1000;
    public float image_width_new;
    public static float time_start;

    public static bool is_timer_start = false;
    public static bool is_timer_end = false;
   
    void Update()
    {
        if (is_timer_start)
        {
            image_width_new = 1000f - (1000f * (Time.time - time_start) / 5f);
            timer_image.GetComponent<RectTransform>().sizeDelta = new Vector2(image_width_new, 15f);
            if (image_width_new <= 0)
            {
                is_timer_start = false;
                is_timer_end = true;
                return;
            }
        }

        if (is_timer_end)
        {
            image_width_new = 1000;
            is_timer_end = false;
        }

    }


}
