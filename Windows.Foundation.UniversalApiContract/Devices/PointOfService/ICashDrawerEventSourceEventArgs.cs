// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerEventSourceEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the arguments common to cash drawer event sources.</summary>
  [Guid(1774926785, 5247, 16924, 156, 35, 9, 1, 35, 187, 120, 108)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICashDrawerEventSourceEventArgs
  {
    /// <summary>Gets the cash drawer associated with the event source.</summary>
    /// <returns>The cash drawer.</returns>
    CashDrawer CashDrawer { get; }
  }
}
