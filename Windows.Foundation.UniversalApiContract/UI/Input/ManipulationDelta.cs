// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ManipulationDelta
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Contains the accumulated transformations for the current manipulation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct ManipulationDelta
  {
    /// <summary>The change in x-y screen coordinates, in device-independent pixel (DIP).</summary>
    public Point Translation;
    /// <summary>The change in distance between touch contacts, as a percentage. For example, if the distance between two contacts changes from 100 device-independent pixel (DIP) to 200 device-independent pixel (DIP) during a manipulation, the value of **Scale** would be 1.0.</summary>
    public float Scale;
    /// <summary>The change in angle of rotation, in degrees.</summary>
    public float Rotation;
    /// <summary>The change in distance between touch contacts, as device-independent pixel (DIP). For example, if the distance between two contacts changes from 100 device-independent pixel (DIP) to 200 device-independent pixel (DIP) during a manipulation, the value of **Expansion** would be 100.0.</summary>
    public float Expansion;
  }
}
