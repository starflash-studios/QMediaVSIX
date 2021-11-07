// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.AnimationDirection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Defines constants that specify the direction in which an animation translates from start to end.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum AnimationDirection
  {
    /// <summary>The animation or transition progresses in a left direction.</summary>
    Left,
    /// <summary>The animation or transition progresses in an up direction.</summary>
    Top,
    /// <summary>The animation or transition progresses in a right direction.</summary>
    Right,
    /// <summary>The animation or transition progresses in a down direction.</summary>
    Bottom,
  }
}
