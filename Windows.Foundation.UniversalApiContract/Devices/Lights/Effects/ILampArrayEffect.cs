// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Effects.ILampArrayEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights.Effects
{
  /// <summary>The base interface for lamp array effects.</summary>
  [Guid(299128208, 22523, 17734, 177, 206, 134, 49, 7, 247, 64, 223)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public interface ILampArrayEffect
  {
    /// <summary>Gets and sets the front-to-back z-index of a lamp array effect within a collection.</summary>
    /// <returns>The front-to-back z-index of a lamp array effect within a collection.</returns>
    int ZIndex { get; set; }
  }
}
