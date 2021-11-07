// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.ActivatedOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.WebUI
{
  /// <summary>Manages an app activation operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ActivatedOperation : IActivatedOperation
  {
    /// <summary>Requests that the completion of app activation be delayed.</summary>
    /// <returns>The activation deferral object.</returns>
    [MethodImpl]
    public extern ActivatedDeferral GetDeferral();
  }
}
