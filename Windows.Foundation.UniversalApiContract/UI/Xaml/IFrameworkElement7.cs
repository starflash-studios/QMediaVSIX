// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElement7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [ExclusiveTo(typeof (FrameworkElement))]
  [Guid(576948332, 49257, 22287, 185, 204, 158, 33, 221, 2, 141, 142)]
  internal interface IFrameworkElement7
  {
    bool IsLoaded { get; }

    event TypedEventHandler<FrameworkElement, EffectiveViewportChangedEventArgs> EffectiveViewportChanged;
  }
}
