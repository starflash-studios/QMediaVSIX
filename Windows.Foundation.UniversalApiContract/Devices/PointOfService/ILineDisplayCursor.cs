// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayCursor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3974102085, 30026, 20027, 171, 43, 21, 17, 129, 8, 86, 5)]
  [ExclusiveTo(typeof (LineDisplayCursor))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ILineDisplayCursor
  {
    bool CanCustomize { get; }

    bool IsBlinkSupported { get; }

    bool IsBlockSupported { get; }

    bool IsHalfBlockSupported { get; }

    bool IsUnderlineSupported { get; }

    bool IsReverseSupported { get; }

    bool IsOtherSupported { get; }

    LineDisplayCursorAttributes GetAttributes();

    [RemoteAsync]
    IAsyncOperation<bool> TryUpdateAttributesAsync(
      LineDisplayCursorAttributes attributes);
  }
}
