// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.AutomationProviderRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Provides the arguments returned by an automation provider request event callback.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class AutomationProviderRequestedEventArgs : 
    IAutomationProviderRequestedEventArgs,
    ICoreWindowEventArgs
  {
    /// <summary>Gets or sets the automation provider object returned by the request event callback.</summary>
    /// <returns>The automation provider object returned by the callback.</returns>
    public extern object AutomationProvider { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the automation provider request event has been handled.</summary>
    /// <returns>True if the automation provider request event has been handled; false if it has not.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
