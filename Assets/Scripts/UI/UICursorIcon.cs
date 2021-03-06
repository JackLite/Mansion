﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICursorIcon : MonoBehaviour
{
    public Sprite defaultIcon;
    public Sprite actionIcon;
    public Sprite lookIcon;

    public float widthDefault;
    public float heightDefalut;
    public float widthAction;
    public float heightAction;
    public float widthLook;
    public float heightLook;

    private Image img;

    // Use this for initialization
    void Start()
    {
        img = GetComponent<Image>();
        img.sprite = defaultIcon;
        img.SetNativeSize();
    }

    public void showDefault()
    {
        setSprite(defaultIcon);
    }
    public void showAction()
    {
        setSprite(actionIcon, widthAction, heightAction);
    }
    public void showLook()
    {
        setSprite(lookIcon, widthLook, heightLook);
    }

    private void setSprite(Sprite icon)
    {
        img.sprite = icon;
        img.SetNativeSize();
    }
    private void setSprite(Sprite icon, float width, float height)
    {
        img.sprite = icon;
        RectTransform transform = img.GetComponent<RectTransform>();
        transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
    }
}
