// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.UI.ICredentialPickerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials.UI
{
  [ExclusiveTo(typeof (CredentialPicker))]
  [Guid(2855951475, 51690, 18306, 153, 251, 230, 215, 233, 56, 225, 45)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICredentialPickerStatics
  {
    [Overload("PickWithOptionsAsync")]
    IAsyncOperation<CredentialPickerResults> PickAsync(
      CredentialPickerOptions options);

    [RemoteAsync]
    [Overload("PickWithMessageAsync")]
    IAsyncOperation<CredentialPickerResults> PickAsync(
      string targetName,
      string message);

    [RemoteAsync]
    [Overload("PickWithCaptionAsync")]
    IAsyncOperation<CredentialPickerResults> PickAsync(
      string targetName,
      string message,
      string caption);
  }
}
