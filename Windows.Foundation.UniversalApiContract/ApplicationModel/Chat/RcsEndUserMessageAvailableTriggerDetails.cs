// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Provides data to the background task about a new message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RcsEndUserMessageAvailableTriggerDetails : 
    IRcsEndUserMessageAvailableTriggerDetails
  {
    /// <summary>Gets the title of the new message.</summary>
    /// <returns>The title of the new message.</returns>
    public extern string Title { [MethodImpl] get; }

    /// <summary>Gets the text of the new message.</summary>
    /// <returns>The text of the new message.</returns>
    public extern string Text { [MethodImpl] get; }
  }
}
