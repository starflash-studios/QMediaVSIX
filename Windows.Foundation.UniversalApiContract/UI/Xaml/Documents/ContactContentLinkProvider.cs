// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ContactContentLinkProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Defines a ContentLink that contains a contact.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactContentLinkProvider : ContentLinkProvider, IContactContentLinkProvider
  {
    /// <summary>Initializes a new instance of the ContactContentLinkProvider class.</summary>
    [MethodImpl]
    public extern ContactContentLinkProvider();
  }
}
