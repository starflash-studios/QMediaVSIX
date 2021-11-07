// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.InjectedInputRectangle
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  /// <summary>The offsets, from the injected pointer, for the bounding box that represents the touch contact area.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public struct InjectedInputRectangle
  {
    /// <summary>The location of the left side of the rectangle, in device-independent pixel (DIP).</summary>
    public int Left;
    /// <summary>The location of the top side of the rectangle, in device-independent pixel (DIP).</summary>
    public int Top;
    /// <summary>The location of the bottom side of the rectangle, in device-independent pixel (DIP).</summary>
    public int Bottom;
    /// <summary>The location of the left side of the rectangle, in device-independent pixel (DIP).</summary>
    public int Right;
  }
}
