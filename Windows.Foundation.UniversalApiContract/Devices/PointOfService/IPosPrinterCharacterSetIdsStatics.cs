// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterCharacterSetIdsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1550884607, 28826, 20455, 178, 21, 6, 167, 72, 163, 139, 57)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PosPrinterCharacterSetIds))]
  internal interface IPosPrinterCharacterSetIdsStatics
  {
    uint Utf16LE { get; }

    uint Ascii { get; }

    uint Ansi { get; }
  }
}
