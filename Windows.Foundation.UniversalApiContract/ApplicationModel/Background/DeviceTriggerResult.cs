// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.DeviceTriggerResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Indicates whether the device background task operation was allowed or denied, and if it was denied specifies the reason.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DeviceTriggerResult
  {
    /// <summary>The device background task was triggered.</summary>
    Allowed,
    /// <summary>The device background task was denied by the user.</summary>
    DeniedByUser,
    /// <summary>The device background task was denied due to system policy.</summary>
    DeniedBySystem,
    /// <summary>The device background task cannot run because the battery is low.</summary>
    LowBattery,
  }
}
