// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IStartScreenManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(145168054, 12651, 19161, 172, 184, 254, 156, 240, 11, 214, 8)]
  [ExclusiveTo(typeof (StartScreenManager))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IStartScreenManager2 : IStartScreenManager
  {
    [RemoteAsync]
    IAsyncOperation<bool> ContainsSecondaryTileAsync(string tileId);

    [RemoteAsync]
    IAsyncOperation<bool> TryRemoveSecondaryTileAsync(string tileId);
  }
}
