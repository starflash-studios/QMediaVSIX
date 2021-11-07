// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayCustomGlyphs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [Guid(576190012, 62051, 17649, 161, 160, 231, 80, 166, 160, 236, 84)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (LineDisplayCustomGlyphs))]
  internal interface ILineDisplayCustomGlyphs
  {
    Size SizeInPixels { get; }

    IVectorView<uint> SupportedGlyphCodes { get; }

    [RemoteAsync]
    IAsyncOperation<bool> TryRedefineAsync(uint glyphCode, IBuffer glyphData);
  }
}
