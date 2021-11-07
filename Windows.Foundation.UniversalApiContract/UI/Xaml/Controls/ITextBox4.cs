// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBox4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBox))]
  [Guid(3052512885, 52449, 17839, 174, 249, 196, 120, 123, 187, 94, 48)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  internal interface ITextBox4
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> GetLinguisticAlternativesAsync();
  }
}
