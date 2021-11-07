// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputPoint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>Contains the screen coordinates of the pointer in device-independent pixel (DIP).</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public struct InjectedInputPoint
  {
    /// <summary>The x-coordinate of the pointer in device-independent pixel (DIP).</summary>
    public int PositionX;
    /// <summary>The y-coordinate of the pointer in device-independent pixel (DIP).</summary>
    public int PositionY;
  }
}
