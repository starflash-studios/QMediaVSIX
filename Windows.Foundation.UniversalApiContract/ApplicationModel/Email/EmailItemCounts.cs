// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailItemCounts
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents the counts for various email message attributes such as flagged, important, unread, and so on.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailItemCounts : IEmailItemCounts
  {
    /// <summary>Gets the number of flagged email messages.</summary>
    /// <returns>The number of flagged email messages.</returns>
    public extern uint Flagged { [MethodImpl] get; }

    /// <summary>Gets the number of important email messages.</summary>
    /// <returns>The number of important email messages.</returns>
    public extern uint Important { [MethodImpl] get; }

    /// <summary>Gets the total number of email messages</summary>
    /// <returns>The total number of email messages.</returns>
    public extern uint Total { [MethodImpl] get; }

    /// <summary>Gets the number of unread email messages.</summary>
    /// <returns>The number of unread email messages.</returns>
    public extern uint Unread { [MethodImpl] get; }
  }
}
