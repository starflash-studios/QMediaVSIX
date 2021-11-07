// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IndependentlyAnimatableAttribute
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  /// <summary>Not intended for general use. This attribute is used by design tools such as Microsoft Visual Studio. Microsoft Visual Studio interprets the attribute and informs app developers how an animation-property combination will work as far as performance and restrictions.</summary>
  [AttributeName("independentlyanimatable")]
  [WebHostHidden]
  [AttributeUsage(global::Windows.Foundation.Metadata.AttributeTargets.Property)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class IndependentlyAnimatableAttribute : Attribute
  {
    /// <summary>Initializes a new instance of the FadeOutThemeAnimation class.</summary>
    [MethodImpl]
    public extern IndependentlyAnimatableAttribute();
  }
}
