using UnityEngine;

public class TapLight : MonoBehaviour {
    public float speed;
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        Default();
    }

    private void Default()
    {
        renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, 1f);
    }

    private void Start()
    {
        if(speed == 0 || speed == null)
        {
            speed = 1;
        }
    }

    private void Update()
    {
        if(renderer.material.color.a <= 0)
        {
            this.enabled = false;
        }
        else
        {
            var alfa = renderer.material.color.a - speed *150*Time.deltaTime;
            renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, alfa);
        }
    }

    public void Tap()
    {
        Default();
    }

}
