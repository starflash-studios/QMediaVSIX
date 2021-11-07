// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebAccountEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>Contains information about an event involving a WebAccount.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  public sealed class WebAccountEventArgs : IWebAccountEventArgs
  {
    /// <summary>Gets the WebAccount involved in the event.</summary>
    /// <returns>The web account involved in the event.</returns>
    public extern WebAccount Account { [MethodImpl] get; }
  }
}
