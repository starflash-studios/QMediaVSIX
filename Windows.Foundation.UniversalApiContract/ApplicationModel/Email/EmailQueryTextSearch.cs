// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailQueryTextSearch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents a text search query in an email mailbox.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailQueryTextSearch : IEmailQueryTextSearch
  {
    /// <summary>Gets or sets the fields for an email text search query.</summary>
    /// <returns>The fields for an email text search query.</returns>
    public extern EmailQuerySearchFields Fields { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scope for an email text search query.</summary>
    /// <returns>The scope for an email text search query.</returns>
    public extern EmailQuerySearchScope SearchScope { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text string for an email text search query.</summary>
    /// <returns>The text string for an email text search query.</returns>
    public extern string Text { [MethodImpl] get; [MethodImpl] set; }
  }
}
