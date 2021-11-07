// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialogButtonClickDeferral
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContentDialogButtonClickDeferral))]
  [Guid(3171759671, 6606, 18758, 142, 119, 189, 3, 254, 142, 190, 3)]
  [WebHostHidden]
  internal interface IContentDialogButtonClickDeferral
  {
    void Complete();
  }
}
