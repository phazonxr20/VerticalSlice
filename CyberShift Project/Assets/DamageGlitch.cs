using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DamageGlitch : MonoBehaviour
{
    public Volume glitchVolume;
    public float fadeSpeed = 0.5f;

    public void TriggerGlitch()
    {
        StopAllCoroutines(); 
        StartCoroutine(GlitchEffectCoroutine());
    }

    IEnumerator GlitchEffectCoroutine()
    {
        glitchVolume.weight = 1f;

        while (glitchVolume.weight > 0)
        {
            glitchVolume.weight -= Time.deltaTime / fadeSpeed;
            yield return null; 
        }

        glitchVolume.weight = 0f;
    }
}
