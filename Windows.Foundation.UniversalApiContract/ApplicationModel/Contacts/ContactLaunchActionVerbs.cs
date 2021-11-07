// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactLaunchActionVerbs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides data when an app is launched to perform an action to a contact.</summary>
  [Static(typeof (IContactLaunchActionVerbsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class ContactLaunchActionVerbs
  {
    /// <summary>Gets the call contact action.</summary>
    /// <returns>The call contact action.</returns>
    public static extern string Call { [MethodImpl] get; }

    /// <summary>Gets the send message to a contact action.</summary>
    /// <returns>The send message to a contact action.</returns>
    public static extern string Message { [MethodImpl] get; }

    /// <summary>Gets the map contact action.</summary>
    /// <returns>The map contact action.</returns>
    public static extern string Map { [MethodImpl] get; }

    /// <summary>Gets the post to a contact action.</summary>
    /// <returns>The post to a contact action.</returns>
    public static extern string Post { [MethodImpl] get; }

    /// <summary>Gets the video call contact action.</summary>
    /// <returns>The video call contact action.</returns>
    public static extern string VideoCall { [MethodImpl] get; }
  }
}
