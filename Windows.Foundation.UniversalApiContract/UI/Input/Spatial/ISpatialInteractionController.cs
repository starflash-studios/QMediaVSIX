// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionController))]
  [Guid(1594776483, 2388, 20119, 134, 197, 231, 243, 11, 17, 77, 253)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialInteractionController
  {
    bool HasTouchpad { get; }

    bool HasThumbstick { get; }

    SimpleHapticsController SimpleHapticsController { get; }

    ushort VendorId { get; }

    ushort ProductId { get; }

    ushort Version { get; }
  }
}
