// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStroke3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1249932148, 38041, 16669, 161, 196, 104, 133, 93, 3, 214, 95)]
  [ExclusiveTo(typeof (InkStroke))]
  internal interface IInkStroke3
  {
    uint Id { get; }

    IReference<DateTime> StrokeStartedTime { get; set; }

    IReference<TimeSpan> StrokeDuration { get; set; }
  }
}
