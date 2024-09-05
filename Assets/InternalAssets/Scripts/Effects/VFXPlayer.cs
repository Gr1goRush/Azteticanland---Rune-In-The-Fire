using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VFXPlayer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _rend;
    [SerializeField] private Sprite[] _frames;

    private void OnValidate()
    {
        _rend ??= GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        StartCoroutine(PlayVFXRoutine(true));
    }

    [ContextMenu("Preview")]
    public void PreviewShow()
    {
        StartCoroutine(PlayVFXRoutine(true));
    }

    private System.Collections.IEnumerator PlayVFXRoutine(bool DestroyAfterShow)
    {
        int SpeedModify = 60;
        for (float i = 1; i < _frames.Length; i+= Time.deltaTime * SpeedModify)
        {
            if (!Settings.GameIsPaused && i < _frames.Length)
            {
                i = Math.Clamp(i, 0, _frames.Length);
                _rend.sprite = _frames[Convert.ToInt16(i) - 1];
            }
            else
            {
                i -= Time.deltaTime * SpeedModify;
                i = Math.Clamp(i, 0, _frames.Length);
            }
            yield return new WaitForEndOfFrame();
        }
        _rend.sprite = _frames[Convert.ToInt32(_frames.Length - 1)];

        if (DestroyAfterShow)
        Destroy(gameObject);
    }
}
