// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewDisplayModeChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3082923317, 21828, 16577, 155, 51, 172, 254, 29, 108, 128, 148)]
  [ExclusiveTo(typeof (NavigationViewDisplayModeChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface INavigationViewDisplayModeChangedEventArgs
  {
    NavigationViewDisplayMode DisplayMode { get; }
  }
}
