// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRefreshRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (RefreshRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(453549891, 53199, 19142, 179, 31, 141, 171, 110, 239, 221, 147)]
  [WebHostHidden]
  internal interface IRefreshRequestedEventArgs
  {
    Deferral GetDeferral();
  }
}
