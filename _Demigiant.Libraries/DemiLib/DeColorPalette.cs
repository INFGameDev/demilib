﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2015/04/26 19:25

using UnityEngine;

#pragma warning disable 1591
namespace DG.DemiLib
{
    /// <summary>
    /// Stores a color palette, which can be passed to default DeGUI layouts when calling <code>DeGUI.BeginGUI</code>,
    /// and changed at any time by calling <code>DeGUI.ChangePalette</code>.
    /// You can inherit from this class to create custom color palettes with more color options.
    /// </summary>
    [System.Serializable]
    public class DeColorPalette
    {
        public DeColorBG bg = new DeColorBG();
        public DeColorContent content = new DeColorContent();
    }

    /// <summary>
    /// Background colors
    /// </summary>
    [System.Serializable]
    public class DeColorBG
    {
        public DeSkinColor def = Color.white;
        public DeSkinColor critical = Color.red;
        public DeSkinColor divider = new DeSkinColor(new Color(0.5f, 0.5f, 0.5f, 1), Color.black);
        public DeSkinColor toggleOn = Color.green;
        public DeSkinColor toggleOff = Color.white;
    }

    /// <summary>
    /// Content colors
    /// </summary>
    [System.Serializable]
    public class DeColorContent
    {
        public DeSkinColor def = new DeSkinColor(Color.black, new Color(0.7f, 0.7f, 0.7f, 1));
        public DeSkinColor critical = new DeSkinColor(new Color(1f, 0.8458418f, 0.4411765f, 1f), new Color(1f, 0.1691176f, 0.1691176f, 1f));
        public DeSkinColor toggleOn = new DeSkinColor(new Color(1f, 0.9686275f, 0.6980392f, 1f), new Color(0.8117647f, 1f, 0.5607843f, 1f));
        public DeSkinColor toggleOff = new DeSkinColor(new Color(0.3529412f, 0.3647059f, 0.3647059f, 1f), new Color(0.5294118f, 0.5294118f, 0.5294118f, 1f));
    }
}