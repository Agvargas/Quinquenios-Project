/// <summary>
/// Created by SwanDEV 2019
/// </summary>

using UnityEngine;

public class CameraOnUpdateRender : CameraRenderBase
{
    private void Update()
    {
        OnUpdateRender();
    }

    private void OnUpdateRender()
    {
        if (!m_ToCapture)
        {
            return;
        }
        m_ToCapture = false;
        
        Display display = Display.displays[rCamera.targetDisplay];
        int W = display.renderingWidth;
        int H = display.renderingHeight;

        RenderTexture renderTexture = new RenderTexture(W, H, 24);
        renderTexture.antiAliasing = m_AntiAliasingLevel;
        rCamera.targetTexture = renderTexture;
        rCamera.Render();
        rCamera.targetTexture = null;

        bool customSize = _targetWidth > 0 && _targetHeight > 0;
        bool subScreenCam = rCamera.rect.width < 1f || rCamera.rect.height < 1f || rCamera.rect.x > 0f || rCamera.rect.y > 0f;
        if (subScreenCam || customSize || _scale != 1f)
        {
            int width = customSize ? _targetWidth : (int)(rCamera.pixelWidth * _scale);
            int height = customSize ? _targetHeight : (int)(rCamera.pixelHeight * _scale);
            _SystemTextureLimit(ref width, ref height);
            Vector2 targetSize = new Vector2(width, height);
            renderTexture = _CutOutAndCropRenderTexture(renderTexture, new Rect(Mathf.CeilToInt(rCamera.pixelRect.x), rCamera.pixelRect.y, rCamera.pixelRect.width, rCamera.pixelRect.height), targetSize, isFullScreen: false);
        }

        if (_onCaptureCallback != null)
        {
            _onCaptureCallback(_RenderTextureToTexture2D(renderTexture));
            _onCaptureCallback = null;
#if UNITY_EDITOR
            //Debug.Log("OnUpdateRender - Texture2D * " + _scale);
#endif
        }
        else if (_onCaptureCallbackRTex != null)
        {
            _onCaptureCallbackRTex(renderTexture);
            _onCaptureCallbackRTex = null;
#if UNITY_EDITOR
            //Debug.Log("OnUpdateRender - RenderTexture * " + _scale);
#endif
        }
    }
}
