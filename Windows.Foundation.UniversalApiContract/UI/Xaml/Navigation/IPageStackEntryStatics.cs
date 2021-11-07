// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.IPageStackEntryStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Navigation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PageStackEntry))]
  [Guid(2901407971, 9324, 16435, 159, 1, 1, 203, 13, 165, 37, 78)]
  [WebHostHidden]
  internal interface IPageStackEntryStatics
  {
    DependencyProperty SourcePageTypeProperty { get; }
  }
}
