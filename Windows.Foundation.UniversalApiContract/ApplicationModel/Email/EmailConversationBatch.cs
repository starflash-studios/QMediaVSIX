// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailConversationBatch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents a group of EmailConversation objects for batch processing.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EmailConversationBatch : IEmailConversationBatch
  {
    /// <summary>Gets a list of EmailConversation objects to use for batch processing.</summary>
    /// <returns>A list of EmailConversation objects to use for batch processing.</returns>
    public extern IVectorView<EmailConversation> Conversations { [MethodImpl] get; }

    /// <summary>Gets the status of the last batch processing operation.</summary>
    /// <returns>The status of the last batch processing operation.</returns>
    public extern EmailBatchStatus Status { [MethodImpl] get; }
  }
}
