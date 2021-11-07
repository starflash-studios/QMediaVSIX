// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactAnnotationOperations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Specifies the types of operations you can perform with a Contact.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum ContactAnnotationOperations : uint
  {
    /// <summary>None</summary>
    None = 0,
    /// <summary>Get the contact profile.</summary>
    ContactProfile = 1,
    /// <summary>Send an SMS/MMS message.</summary>
    Message = 2,
    /// <summary>Make and audio call.</summary>
    AudioCall = 4,
    /// <summary>Make a video call.</summary>
    VideoCall = 8,
    /// <summary>Access social media feeds.</summary>
    SocialFeeds = 16, // 0x00000010
    /// <summary>Share the contact.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Share = 32, // 0x00000020
  }
}
