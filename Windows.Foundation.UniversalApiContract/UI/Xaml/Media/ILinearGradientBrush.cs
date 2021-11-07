// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILinearGradientBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (LinearGradientBrush))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2392248683, 48004, 19567, 157, 191, 157, 108, 92, 109, 156, 57)]
  internal interface ILinearGradientBrush
  {
    Point StartPoint { get; set; }

    Point EndPoint { get; set; }
  }
}
