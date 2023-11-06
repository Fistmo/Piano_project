using UnityEngine;
using System.Collections;
using TMPro;

public class CommentMesh : MonoBehaviour {
    private string nowText;
    private string newText;
    private float time = 0;
    private float destroyTime = 2f;
    public TMP_Text textMesh; // 将变量的类型更改为TMP_Text

    private void Awake()
    {
        // 不再需要这行，因为在声明时已经分配了
        // textMesh = GetComponent<TextMesh>();
    }

    private void Update()
    {
        newText = textMesh.text;
        if (nowText == newText)
        {
            time += Time.deltaTime;
            // 使用fontSize来设置字符大小
            textMesh.fontSize = 140 + (int)(time / 1.3f * 100); // 根据需要调整大小倍数
            if (time >= 0.1f)
            {
                var alpha = textMesh.color.a - destroyTime * Time.deltaTime;
                textMesh.color = new Color(textMesh.color.r, textMesh.color.g, textMesh.color.b, alpha);
                textMesh.gameObject.SetActive(alpha > 0);
            }
        }
        else
        {
            OnEnable();
        }
    }

    private void OnEnable()
    {
        time = 0f;
        textMesh.fontSize = 14; // 设置初始字体大小
        nowText = newText;
        textMesh.color = new Color(textMesh.color.r, textMesh.color.g, textMesh.color.b, 1f);
    }
}
