// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPointFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Defines the implementation for a type that generates InkPoint objects used in the construction of an InkStroke.</summary>
  [Guid(702928156, 51599, 16477, 159, 59, 229, 62, 49, 6, 141, 77)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IInkPointFactory
  {
    /// <summary>Generates an InkPoint object that includes position and pressure information used in the construction of an InkStroke.</summary>
    /// <param name="position">The screen coordinates for the InkPoint object.</param>
    /// <param name="pressure">The pressure of the contact on the digitizer surface. The default is 0.5.</param>
    /// <returns>A single point.</returns>
    InkPoint CreateInkPoint(Point position, float pressure);
  }
}
