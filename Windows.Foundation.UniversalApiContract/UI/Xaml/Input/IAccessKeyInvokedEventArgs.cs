// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IAccessKeyInvokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AccessKeyInvokedEventArgs))]
  [Guid(3488206231, 50968, 16529, 183, 221, 173, 241, 192, 114, 177, 225)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAccessKeyInvokedEventArgs
  {
    bool Handled { get; set; }
  }
}
