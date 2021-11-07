// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NotifyEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the ScriptNotify event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class NotifyEventArgs : INotifyEventArgs, INotifyEventArgs2
  {
    /// <summary>Gets the method name as passed to the application.</summary>
    /// <returns>The JavaScript method name.</returns>
    public extern string Value { [MethodImpl] get; }

    /// <summary>Gets the Uniform Resource Identifier (URI) of the page containing the script that raised the ScriptNotify event.</summary>
    /// <returns>The Uniform Resource Identifier (URI) of the page that raised the event.</returns>
    public extern Uri CallingUri { [MethodImpl] get; }
  }
}
