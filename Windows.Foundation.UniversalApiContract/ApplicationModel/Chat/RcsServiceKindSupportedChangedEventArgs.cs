// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsServiceKindSupportedChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides data for the ServiceKindSupportedChanged event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RcsServiceKindSupportedChangedEventArgs : 
    IRcsServiceKindSupportedChangedEventArgs
  {
    /// <summary>Gets the type of the Rich Communication Services (RCS) service.</summary>
    /// <returns>The type of the Rich Communication Services (RCS) service.</returns>
    public extern RcsServiceKind ServiceKind { [MethodImpl] get; }
  }
}
