// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayWindow
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3525308148, 9060, 19429, 190, 225, 133, 22, 128, 175, 73, 100)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (LineDisplayWindow))]
  internal interface ILineDisplayWindow
  {
    Size SizeInCharacters { get; }

    TimeSpan InterCharacterWaitInterval { get; set; }

    [RemoteAsync]
    IAsyncOperation<bool> TryRefreshAsync();

    [RemoteAsync]
    [Overload("TryDisplayTextAsync")]
    IAsyncOperation<bool> TryDisplayTextAsync(
      string text,
      LineDisplayTextAttribute displayAttribute);

    [Overload("TryDisplayTextAtPositionAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryDisplayTextAsync(
      string text,
      LineDisplayTextAttribute displayAttribute,
      Point startPosition);

    [RemoteAsync]
    [Overload("TryDisplayTextNormalAsync")]
    IAsyncOperation<bool> TryDisplayTextAsync(string text);

    [RemoteAsync]
    IAsyncOperation<bool> TryScrollTextAsync(
      LineDisplayScrollDirection direction,
      uint numberOfColumnsOrRows);

    [RemoteAsync]
    IAsyncOperation<bool> TryClearTextAsync();
  }
}
