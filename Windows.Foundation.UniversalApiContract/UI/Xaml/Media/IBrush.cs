// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (Brush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2282136353, 7686, 16940, 161, 204, 1, 105, 101, 89, 224, 33)]
  [WebHostHidden]
  internal interface IBrush
  {
    double Opacity { get; set; }

    Transform Transform { get; set; }

    Transform RelativeTransform { get; set; }
  }
}
