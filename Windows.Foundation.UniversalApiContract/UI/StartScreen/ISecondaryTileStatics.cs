// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(2576387502, 53329, 18038, 135, 254, 158, 194, 66, 216, 60, 116)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SecondaryTile))]
  internal interface ISecondaryTileStatics
  {
    bool Exists(string tileId);

    [RemoteAsync]
    [Overload("FindAllAsync")]
    IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync();

    [Overload("FindAllForApplicationAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync(
      string applicationId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<SecondaryTile>> FindAllForPackageAsync();
  }
}
