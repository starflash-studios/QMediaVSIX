#region Copyright (C) 2017-2021  Starflash Studios
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html
#endregion

#region Using Directives

using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

#endregion

namespace QMediaVSIX.Environment.Effects;

// ReSharper disable once CommentTypo
/// <summary>
/// Courtesy of <see href="https://stackoverflow.com/a/45096471/11519246">Pater Duniho</see>.
/// </summary>
/// <remarks>
/// This code is licensed under Creative Commons Attribution-ShareAlike 4.0 Internal (CC BY-SA 4.0).
/// <br/>You are free to:
/// <list type="bullet"><item>
/// <term>Share</term>
/// <description> copy and redistribute the material in any medium or format</description>
/// </item><item>
/// <term>Adapt</term>
/// <description> remix, transform, and build upon the material for any purpose, even commercially.</description>
/// </item></list>
/// This is a human-readable summary of (and not a substitute for) the <see href="https://creativecommons.org/licenses/by-sa/4.0/legalcode">license</see>.
/// <para/>For more information, please visit: <see href="https://creativecommons.org/licenses/by-sa/4.0/"/>
/// </remarks>
public class InvertEffect : ShaderEffect {
  const string KshaderAsBase64 =
    @"AAP///7/HwBDVEFCHAAAAE8AAAAAA///AQAAABwAAAAAAQAASAAAADAAAAADAAAAAQACADgAAAAA
AAAAaW5wdXQAq6sEAAwAAQABAAEAAAAAAAAAcHNfM18wAE1pY3Jvc29mdCAoUikgSExTTCBTaGFk
ZXIgQ29tcGlsZXIgMTAuMQCrUQAABQAAD6AAAIA/AAAAAAAAAAAAAAAAHwAAAgUAAIAAAAOQHwAA
AgAAAJAACA+gQgAAAwAAD4AAAOSQAAjkoAIAAAMAAAeAAADkgQAAAKAFAAADAAgHgAAA/4AAAOSA
AQAAAgAICIAAAP+A//8AAA==";

  static readonly PixelShader _Shader;

  static InvertEffect() {
    _Shader = new PixelShader();
    _Shader.SetStreamSource(new MemoryStream(Convert.FromBase64String(KshaderAsBase64)));
  }

  public InvertEffect() {
    PixelShader = _Shader;
    UpdateShaderValue(InputProperty);
  }

  public Brush Input {
    get => (Brush)GetValue(InputProperty);
    set => SetValue(InputProperty, value);
  }

  public static readonly DependencyProperty InputProperty =
    RegisterPixelShaderSamplerProperty("Input", typeof(InvertEffect), 0);

}