// Decompiled with JetBrains decompiler
// Type: Windows.UI.Shell.ITaskbarManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.StartScreen;

namespace Windows.UI.Shell
{
  [Guid(2045812846, 31490, 18705, 145, 140, 222, 224, 187, 210, 11, 164)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (TaskbarManager))]
  internal interface ITaskbarManager2 : ITaskbarManager
  {
    [RemoteAsync]
    IAsyncOperation<bool> IsSecondaryTilePinnedAsync(string tileId);

    [RemoteAsync]
    IAsyncOperation<bool> RequestPinSecondaryTileAsync(SecondaryTile secondaryTile);

    [RemoteAsync]
    IAsyncOperation<bool> TryUnpinSecondaryTileAsync(string tileId);
  }
}
