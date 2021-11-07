// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IAppListEntry2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3500546221, 48949, 17068, 172, 6, 134, 238, 235, 65, 208, 75)]
  [ExclusiveTo(typeof (AppListEntry))]
  internal interface IAppListEntry2
  {
    string AppUserModelId { get; }
  }
}
