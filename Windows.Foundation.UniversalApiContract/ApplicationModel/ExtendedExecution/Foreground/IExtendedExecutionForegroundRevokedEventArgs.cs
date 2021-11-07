// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ExtendedExecution.Foreground.IExtendedExecutionForegroundRevokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ExtendedExecution.Foreground
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2960972096, 38231, 44708, 44, 153, 189, 213, 109, 155, 228, 97)]
  [ExclusiveTo(typeof (ExtendedExecutionForegroundRevokedEventArgs))]
  internal interface IExtendedExecutionForegroundRevokedEventArgs
  {
    ExtendedExecutionForegroundRevokedReason Reason { get; }
  }
}
