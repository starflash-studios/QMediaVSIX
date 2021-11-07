// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatQueryOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents the criteria for finding chat messages.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ChatQueryOptions : IChatQueryOptions
  {
    /// <summary>Initializes a new instance of the ChatQueryOptions class.</summary>
    [MethodImpl]
    public extern ChatQueryOptions();

    /// <summary>Gets or sets the string to search for the in ChatMessageStore.</summary>
    /// <returns>The string to search for the in ChatMessageStore.</returns>
    public extern string SearchString { [MethodImpl] get; [MethodImpl] set; }
  }
}
