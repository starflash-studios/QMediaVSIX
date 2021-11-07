// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IAppListEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ExclusiveTo(typeof (AppListEntry))]
  [Guid(4009816191, 8456, 18698, 135, 122, 138, 159, 23, 194, 95, 173)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppListEntry
  {
    AppDisplayInfo DisplayInfo { get; }

    [RemoteAsync]
    IAsyncOperation<bool> LaunchAsync();
  }
}
