// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPoint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(3918868861, 29334, 17113, 130, 51, 197, 190, 115, 183, 74, 74)]
  [ExclusiveTo(typeof (PointerPoint))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerPoint
  {
    PointerDevice PointerDevice { get; }

    Point Position { get; }

    Point RawPosition { get; }

    uint PointerId { get; }

    uint FrameId { get; }

    ulong Timestamp { get; }

    bool IsInContact { get; }

    PointerPointProperties Properties { get; }
  }
}
