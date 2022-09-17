using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Ihatessao : MonoBehaviour
{
    public bool SSAO_Active;

    public ScriptableRendererFeature ssao;

    public void toggleSSAO(bool _bool)
    {
        ssao.SetActive(SSAO_Active);
    }
}