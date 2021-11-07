// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IMouseWheelParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(3939551812, 40429, 16439, 129, 73, 94, 76, 194, 86, 68, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MouseWheelParameters))]
  internal interface IMouseWheelParameters
  {
    Point CharTranslation { get; set; }

    float DeltaScale { get; set; }

    float DeltaRotationAngle { get; set; }

    Point PageTranslation { get; set; }
  }
}
