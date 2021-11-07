// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.IPerceptionFrameSourcePropertiesChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [ExclusiveTo(typeof (PerceptionFrameSourcePropertiesChangedEventArgs))]
  [Guid(1818812520, 48369, 20172, 184, 145, 118, 37, 209, 36, 75, 107)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionFrameSourcePropertiesChangedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionFrameSourcePropertiesChangedEventArgs
  {
    CollectionChange CollectionChange { [Deprecated("PerceptionFrameSourcePropertiesChangedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    string Key { [Deprecated("PerceptionFrameSourcePropertiesChangedEventArgs may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
