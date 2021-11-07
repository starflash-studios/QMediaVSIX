// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppDiagnosticInfo2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ExclusiveTo(typeof (AppDiagnosticInfo))]
  [Guid(3745971159, 6426, 17516, 148, 115, 143, 188, 35, 116, 163, 84)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IAppDiagnosticInfo2
  {
    IVector<AppResourceGroupInfo> GetResourceGroups();

    AppResourceGroupInfoWatcher CreateResourceGroupWatcher();
  }
}
