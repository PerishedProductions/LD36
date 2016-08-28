using UnityEngine;

[RequireComponent(typeof(Light))]
public class TorchFlicker : MonoBehaviour
{
    public float minIntensity = 0.25f;
    public float maxIntensity = 0.5f;

    private Light torchLight;

    float random;

    void Start()
    {
        torchLight = this.GetComponent<Light>();
        random = Random.Range(0.0f, 65535.0f);
    }

    void Update()
    {
        float noise = Mathf.PerlinNoise(random, Time.time);
        torchLight.intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}