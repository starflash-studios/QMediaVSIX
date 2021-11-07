// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ApplicationRequiresPointerMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Specifies the interaction experiences for non-pointer devices such as an Xbox controller or remote control.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public enum ApplicationRequiresPointerMode
  {
    /// <summary>The default system experience for the input device.</summary>
    Auto,
    /// <summary>A pointer-like interaction experience using a mouse cursor that can be freely moved using non-pointer input devices.</summary>
    WhenRequested,
  }
}
