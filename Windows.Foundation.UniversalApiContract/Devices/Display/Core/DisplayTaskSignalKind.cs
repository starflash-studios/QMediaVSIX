// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayTaskSignalKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Defines constants that specify a signal kind.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DisplayTaskSignalKind
  {
    /// <summary>Specifies a signal that flips away on *Present*.</summary>
    OnPresentFlipAway,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] OnPresentFlipTo,
  }
}
