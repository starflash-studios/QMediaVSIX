// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPointProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (PointerPointProperties))]
  [Guid(3348990539, 49507, 20199, 128, 63, 103, 206, 121, 249, 151, 45)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerPointProperties
  {
    float Pressure { get; }

    bool IsInverted { get; }

    bool IsEraser { get; }

    float Orientation { get; }

    float XTilt { get; }

    float YTilt { get; }

    float Twist { get; }

    Rect ContactRect { get; }

    Rect ContactRectRaw { get; }

    bool TouchConfidence { get; }

    bool IsLeftButtonPressed { get; }

    bool IsRightButtonPressed { get; }

    bool IsMiddleButtonPressed { get; }

    int MouseWheelDelta { get; }

    bool IsHorizontalMouseWheel { get; }

    bool IsPrimary { get; }

    bool IsInRange { get; }

    bool IsCanceled { get; }

    bool IsBarrelButtonPressed { get; }

    bool IsXButton1Pressed { get; }

    bool IsXButton2Pressed { get; }

    PointerUpdateKind PointerUpdateKind { get; }

    bool HasUsage(uint usagePage, uint usageId);

    int GetUsageValue(uint usagePage, uint usageId);
  }
}
