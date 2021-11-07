// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.INavigationEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Navigation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3064633396, 26257, 17617, 189, 247, 88, 130, 12, 39, 176, 208)]
  [ExclusiveTo(typeof (NavigationEventArgs))]
  [WebHostHidden]
  internal interface INavigationEventArgs
  {
    object Content { get; }

    object Parameter { get; }

    TypeName SourcePageType { get; }

    NavigationMode NavigationMode { get; }

    Uri Uri { get; set; }
  }
}
