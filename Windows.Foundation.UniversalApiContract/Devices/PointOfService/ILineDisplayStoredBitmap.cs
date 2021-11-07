// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayStoredBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (LineDisplayStoredBitmap))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(4129378651, 55326, 17338, 191, 27, 188, 250, 60, 120, 91, 160)]
  internal interface ILineDisplayStoredBitmap
  {
    string EscapeSequence { get; }

    [RemoteAsync]
    IAsyncOperation<bool> TryDeleteAsync();
  }
}
