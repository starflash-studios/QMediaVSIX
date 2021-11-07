// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Provider.ICachedFileUpdaterUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Provider
{
  [ExclusiveTo(typeof (CachedFileUpdaterUI))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2658091494, 47858, 19095, 182, 0, 147, 51, 245, 223, 128, 253)]
  internal interface ICachedFileUpdaterUI
  {
    string Title { get; set; }

    CachedFileTarget UpdateTarget { get; }

    event TypedEventHandler<CachedFileUpdaterUI, FileUpdateRequestedEventArgs> FileUpdateRequested;

    event TypedEventHandler<CachedFileUpdaterUI, object> UIRequested;

    UIStatus UIStatus { get; }
  }
}
