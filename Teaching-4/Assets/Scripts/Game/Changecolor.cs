using UnityEngine;

public class Changecolor : MonoBehaviour
{
    public float colorChangeSpeed = 1.0f; // 控制颜色变化的速度
    private Material material;
    private Color startColor;
    private Color targetColor;
    private float startTime;

    void Start()
    {
        material = GetComponent<Renderer>().material; // 获取游戏对象的材质
        startColor = material.color; // 获取开始时的颜色
        targetColor = RandomColor(); // 生成随机目标颜色
        startTime = Time.time; // 记录开始时间
    }

    void Update()
    {
        float t = (Time.time - startTime) * colorChangeSpeed; // 根据时间计算插值系数
        material.color = Color.Lerp(startColor, targetColor, t); // 使用Lerp函数进行颜色插值

        if (t >= 1.0f)
        {
            startColor = material.color; // 更新开始颜色为当前颜色
            targetColor = RandomColor(); // 生成新的随机目标颜色
            startTime = Time.time; // 重置开始时间
        }
    }

    // 生成随机颜色
    Color RandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
