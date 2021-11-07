// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IViewboxStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1557260077, 59603, 18533, 143, 8, 182, 178, 214, 137, 173, 241)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Viewbox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IViewboxStatics
  {
    DependencyProperty StretchProperty { get; }

    DependencyProperty StretchDirectionProperty { get; }
  }
}
