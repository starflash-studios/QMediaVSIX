// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemWebAccountFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.System.RemoteSystems
{
  /// <summary>An IRemoteSystemFilter that limits the set of discoverable remote systems by allowing only those which are signed in with a certain web account.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Activatable(typeof (IRemoteSystemWebAccountFilterFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RemoteSystemWebAccountFilter : 
    IRemoteSystemWebAccountFilter,
    IRemoteSystemFilter
  {
    /// <summary>Initializes an instance of the RemoteSystemWebAccountFilter class.</summary>
    /// <param name="account">The web account to target.</param>
    [MethodImpl]
    public extern RemoteSystemWebAccountFilter(WebAccount account);

    /// <summary>The web account that the containing RemoteSystemStatusTypeFilter object targets.</summary>
    /// <returns>The web account to target.</returns>
    public extern WebAccount Account { [MethodImpl] get; }
  }
}
