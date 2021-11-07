// Decompiled with JetBrains decompiler
// Type: Windows.Management.Update.IPreviewBuildsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Update
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(4194819425, 32335, 23031, 124, 159, 222, 249, 5, 28, 95, 98)]
  [ExclusiveTo(typeof (PreviewBuildsManager))]
  internal interface IPreviewBuildsManager
  {
    bool ArePreviewBuildsAllowed { get; set; }

    PreviewBuildsState GetCurrentState();

    [RemoteAsync]
    IAsyncOperation<bool> SyncAsync();
  }
}
