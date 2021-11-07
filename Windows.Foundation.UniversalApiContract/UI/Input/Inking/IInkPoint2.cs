// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPoint2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4222206967, 44630, 19804, 189, 47, 10, 196, 95, 94, 74, 249)]
  [ExclusiveTo(typeof (InkPoint))]
  internal interface IInkPoint2
  {
    float TiltX { get; }

    float TiltY { get; }

    ulong Timestamp { get; }
  }
}
