using UnityEngine;

public class Fade : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    
    private CanvasGroup _canvasGroup;

    [SerializeField] private bool _fadeIn;
    [SerializeField] private bool _fadeOut;

    private void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();

        _fadeIn = true;
    }

    private void Update()
    {
        FadeIn();
        FadeOut();
    }

    private void FadeIn()
    {
        if (_fadeIn)
        {
            if (_canvasGroup.alpha < 1)
            {
                _canvasGroup.alpha += speed * Time.deltaTime;

                if (_canvasGroup.alpha >= 1)
                {
                    _fadeIn = false;
                }
            }
        }
    }

    private void FadeOut()
    {
        if (_fadeOut)
        {
            if (_canvasGroup.alpha >= 0)
            {
                _canvasGroup.alpha -= speed * Time.deltaTime;

                if (_canvasGroup.alpha == 0)
                {
                    _fadeOut = false;
                }
            }
        }
    }
}