// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPointFactory2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(3759431301, 56063, 17906, 173, 105, 5, 13, 130, 86, 162, 9)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (InkPoint))]
  internal interface IInkPointFactory2
  {
    InkPoint CreateInkPointWithTiltAndTimestamp(
      Point position,
      float pressure,
      float tiltX,
      float tiltY,
      ulong timestamp);
  }
}
