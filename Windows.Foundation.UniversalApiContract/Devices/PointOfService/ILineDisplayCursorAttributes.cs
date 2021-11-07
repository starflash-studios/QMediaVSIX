// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ILineDisplayCursorAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1311593726, 20477, 16784, 170, 225, 206, 40, 95, 32, 200, 150)]
  [ExclusiveTo(typeof (LineDisplayCursorAttributes))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ILineDisplayCursorAttributes
  {
    bool IsBlinkEnabled { get; set; }

    LineDisplayCursorType CursorType { get; set; }

    bool IsAutoAdvanceEnabled { get; set; }

    Point Position { get; set; }
  }
}
