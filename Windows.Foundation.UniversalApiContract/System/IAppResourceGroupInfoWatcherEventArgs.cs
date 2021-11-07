// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppResourceGroupInfoWatcherEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(2054714935, 25346, 19759, 191, 137, 28, 18, 208, 178, 166, 185)]
  [ExclusiveTo(typeof (AppResourceGroupInfoWatcherEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppResourceGroupInfoWatcherEventArgs
  {
    IVectorView<AppDiagnosticInfo> AppDiagnosticInfos { get; }

    AppResourceGroupInfo AppResourceGroupInfo { get; }
  }
}
