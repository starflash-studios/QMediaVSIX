// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ICanExecuteRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (CanExecuteRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Guid(3370603094, 6480, 20573, 153, 59, 117, 144, 126, 249, 104, 48)]
  internal interface ICanExecuteRequestedEventArgs
  {
    object Parameter { get; }

    bool CanExecute { get; set; }
  }
}
