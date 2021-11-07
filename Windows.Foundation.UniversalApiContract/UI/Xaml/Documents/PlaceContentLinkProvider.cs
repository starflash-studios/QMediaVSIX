// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.PlaceContentLinkProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Defines a ContentLink that contains a place.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlaceContentLinkProvider : ContentLinkProvider, IPlaceContentLinkProvider
  {
    /// <summary>Initializes a new instance of the PlaceContentLinkProvider class.</summary>
    [MethodImpl]
    public extern PlaceContentLinkProvider();
  }
}
