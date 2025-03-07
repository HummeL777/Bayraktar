using UnityEngine;
using UnityEngine.Rendering.Universal;
using Zenject;

public class LevelGraphicInitializer : MonoBehaviour
{
    [SerializeField] private UniversalRendererData defaultRenderer = null;

    [Inject] private Level levelSettings = null;
    private Material _fogMaterial = null;

    private void Awake()
    {
        _fogMaterial = levelSettings.LevelGraphics.Fog;
    }

    private void OnEnable()
    {
        ScriptableRendererFeature[] rendererFeatures = defaultRenderer.rendererFeatures.ToArray();
        foreach(ScriptableRendererFeature feature in rendererFeatures)
        {
            if (feature.GetType() == typeof(Blit))
            {
                Blit blit = (Blit)feature;
                if (blit && blit.name == "Fog")
                {
                    blit.blitPass.blitMaterial = _fogMaterial;
                    break;
                }
            }
        }
    }
}
