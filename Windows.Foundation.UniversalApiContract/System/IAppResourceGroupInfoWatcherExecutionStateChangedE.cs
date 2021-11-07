// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(467398103, 65254, 20436, 152, 221, 233, 42, 44, 194, 153, 243)]
  [ExclusiveTo(typeof (AppResourceGroupInfoWatcherExecutionStateChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs
  {
    IVectorView<AppDiagnosticInfo> AppDiagnosticInfos { get; }

    AppResourceGroupInfo AppResourceGroupInfo { get; }
  }
}
