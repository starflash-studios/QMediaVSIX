// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionPropertyChangeRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  [Guid(1012591441, 13579, 19960, 148, 20, 89, 224, 152, 21, 81, 11)]
  [ExclusiveTo(typeof (PerceptionPropertyChangeRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionPropertyChangeRequest
  {
    string Name { [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    object Value { [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] [return: Variant] get; }

    PerceptionFrameSourcePropertyChangeStatus Status { [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] set; }

    [Deprecated("PerceptionPropertyChangeRequest may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    Deferral GetDeferral();
  }
}
