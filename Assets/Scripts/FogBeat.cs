using UnityEngine;
using System.Collections;

public class FogBeat : MonoBehaviour
{
    public int samples = 64;
    public int channel = 0;
    public int frequencyChannel = 32;
    public float amplitudeMultiplier = 100.0f;
    public FFTWindow window;

    private float originalFogEnd = 125;

	// Use this for initialization
	void Start ()
    {
        originalFogEnd = RenderSettings.fogEndDistance;

    }
	
	// Update is called once per frame
	void Update ()
    {
        float[] data = new float[samples];
        AudioListener.GetSpectrumData(data, channel, window);
        RenderSettings.fogEndDistance = originalFogEnd + data[frequencyChannel]*amplitudeMultiplier*-1;
	}
}
