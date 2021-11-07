// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Provides information about the trigger that started the web account provider task.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class WebAccountProviderTriggerDetails : 
    IWebAccountProviderTokenObjects,
    IWebAccountProviderTokenObjects2
  {
    /// <summary>Gets the web account provider operation.</summary>
    /// <returns>The web account provider operation.</returns>
    public extern IWebAccountProviderOperation Operation { [MethodImpl] get; }

    /// <summary>Gets the user that issued this web account provider trigger (for use with multi-user-aware apps).</summary>
    /// <returns>The user for this trigger.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
