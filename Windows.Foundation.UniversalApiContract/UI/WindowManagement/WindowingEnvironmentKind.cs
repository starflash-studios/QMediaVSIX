// Decompiled with JetBrains decompiler
// Type: Windows.UI.WindowManagement.WindowingEnvironmentKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WindowManagement
{
  /// <summary>Defines constants the specify what kind a windowing environment is.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum WindowingEnvironmentKind
  {
    /// <summary>The windowing environment is not known.</summary>
    Unknown,
    /// <summary>The windowing environment supports windows that overlap.</summary>
    Overlapped,
    /// <summary>The windowing environment supports only windows that do not overlap.</summary>
    Tiled,
  }
}
