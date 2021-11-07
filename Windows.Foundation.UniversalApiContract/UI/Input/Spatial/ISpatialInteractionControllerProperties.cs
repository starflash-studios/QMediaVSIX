// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionControllerProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [Guid(1627746225, 31657, 20021, 185, 63, 146, 114, 203, 169, 178, 139)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialInteractionControllerProperties))]
  internal interface ISpatialInteractionControllerProperties
  {
    bool IsTouchpadTouched { get; }

    bool IsTouchpadPressed { get; }

    bool IsThumbstickPressed { get; }

    double ThumbstickX { get; }

    double ThumbstickY { get; }

    double TouchpadX { get; }

    double TouchpadY { get; }
  }
}
