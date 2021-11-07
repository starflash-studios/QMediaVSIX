// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IExceptionRoutedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ExceptionRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3718246762, 19298, 19052, 164, 157, 6, 113, 239, 97, 54, 190)]
  internal interface IExceptionRoutedEventArgs
  {
    string ErrorMessage { get; }
  }
}
