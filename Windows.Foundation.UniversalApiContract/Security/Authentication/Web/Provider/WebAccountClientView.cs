// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountClientView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents the client view for a web account. Use this to control what information about an account from a provider is available to the client.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IWebAccountClientViewFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebAccountClientView : IWebAccountClientView
  {
    [MethodImpl]
    public extern WebAccountClientView(
      WebAccountClientViewType viewType,
      Uri applicationCallbackUri);

    [MethodImpl]
    public extern WebAccountClientView(
      WebAccountClientViewType viewType,
      Uri applicationCallbackUri,
      string accountPairwiseId);

    /// <summary>Gets the app callback Uri.</summary>
    /// <returns>The app callback Uri.</returns>
    public extern Uri ApplicationCallbackUri { [MethodImpl] get; }

    /// <summary>Gets the type of web account client view.</summary>
    /// <returns>The web account client view type.</returns>
    public extern WebAccountClientViewType Type { [MethodImpl] get; }

    /// <summary>Gets the account pairwise Id.</summary>
    /// <returns>The account pairwise Id.</returns>
    public extern string AccountPairwiseId { [MethodImpl] get; }
  }
}
