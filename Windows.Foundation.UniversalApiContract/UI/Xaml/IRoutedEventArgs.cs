// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1553488582, 55298, 19256, 162, 35, 191, 7, 12, 67, 254, 223)]
  internal interface IRoutedEventArgs
  {
    object OriginalSource { get; }
  }
}
