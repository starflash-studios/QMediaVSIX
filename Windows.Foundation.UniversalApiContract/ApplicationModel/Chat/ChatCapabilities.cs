// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  /// <summary>Represents the Rich Communication Services (RCS) chat capabilities of a phone number.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ChatCapabilities : IChatCapabilities
  {
    /// <summary>Gets a Boolean value indicating if an Rich Communication Services (RCS) capable phone number is online.</summary>
    /// <returns>A Boolean value indicating if an Rich Communication Services (RCS) capable phone number is online.</returns>
    public extern bool IsOnline { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating whether a phone number supports Rich Communication Services (RCS) chat.</summary>
    /// <returns>A Boolean value indicating whether the app supports chat.</returns>
    public extern bool IsChatCapable { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if a phone number supports Rich Communication Services (RCS) file transfer.</summary>
    /// <returns>A Boolean value indicating if a phone number supports Rich Communication Services (RCS) file transfer.</returns>
    public extern bool IsFileTransferCapable { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if a phone number is capable of pushing Rich Communication Services (RCS) geolocation.</summary>
    /// <returns>A Boolean value indicating if a phone number is capable of pushing Rich Communication Services (RCS) geolocation.</returns>
    public extern bool IsGeoLocationPushCapable { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if a phone number supports Rich Communication Services (RCS) integrated messaging.</summary>
    /// <returns>A Boolean value indicating if a phone number supports Rich Communication Services (RCS) integrated messaging.</returns>
    public extern bool IsIntegratedMessagingCapable { [MethodImpl] get; }
  }
}
