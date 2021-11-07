// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Vector3TransitionComponents
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Defines constants that specify which axes to animate during the Vector3Transition animation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Flags]
  [WebHostHidden]
  public enum Vector3TransitionComponents : uint
  {
    /// <summary>Animate the X axis.</summary>
    X = 1,
    /// <summary>Animate the Y axis.</summary>
    Y = 2,
    /// <summary>Animate the Z axis.</summary>
    Z = 4,
  }
}
