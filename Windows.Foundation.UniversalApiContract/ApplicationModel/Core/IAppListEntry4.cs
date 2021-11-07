// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IAppListEntry4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (AppListEntry))]
  [Guid(705896146, 22261, 18556, 134, 151, 81, 102, 243, 179, 61, 160)]
  [ContractVersion(typeof (UniversalApiContract), 720896)]
  internal interface IAppListEntry4
  {
    AppInfo AppInfo { get; }
  }
}
