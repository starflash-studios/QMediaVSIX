// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IAppInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3481229747, 27145, 19944, 166, 192, 87, 146, 213, 104, 128, 209)]
  [ExclusiveTo(typeof (AppInfo))]
  internal interface IAppInfo
  {
    string Id { get; }

    string AppUserModelId { get; }

    AppDisplayInfo DisplayInfo { get; }

    string PackageFamilyName { get; }
  }
}
