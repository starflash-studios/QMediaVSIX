// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ICachedFileUpdaterTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CachedFileUpdaterTriggerDetails))]
  [Guid(1904446483, 4884, 18356, 149, 151, 220, 126, 36, 140, 23, 204)]
  internal interface ICachedFileUpdaterTriggerDetails
  {
    CachedFileTarget UpdateTarget { get; }

    FileUpdateRequest UpdateRequest { get; }

    bool CanRequestUserInput { get; }
  }
}
