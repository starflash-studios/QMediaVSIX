// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.SemanticTextQuery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Permits apps to perform text queries using Advanced Query Syntax (AQS) strings, with the option of providing a language tag to be employed in the query.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISemanticTextQueryFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SemanticTextQuery : ISemanticTextQuery
  {
    /// <summary>Creates a SemanticTextQuery from an Advanced Query Syntax (AQS) query string.</summary>
    /// <param name="aqsFilter">An Advanced Query Syntax (AQS) string that contains the desired query. Learn more about AQS in Advanced Query Syntax (AQS).</param>
    [MethodImpl]
    public extern SemanticTextQuery(string aqsFilter);

    /// <summary>Creates a SemanticTextQuery from an Advanced Query Syntax (AQS) query string and a language tag.</summary>
    /// <param name="aqsFilter">An Advanced Query Syntax (AQS) string that contains the desired query. Learn more about Advanced Query Syntax (AQS) in .</param>
    /// <param name="filterLanguage">The BCP-47 language tag to be employed in the query.</param>
    [MethodImpl]
    public extern SemanticTextQuery(string aqsFilter, string filterLanguage);

    /// <summary>Returns segments of a source string that match the SemanticTextQuery object's query.</summary>
    /// <param name="content">A source string to be queried.</param>
    /// <returns>A collection of TextSegment structures that represent hits from the query.</returns>
    [MethodImpl]
    public extern IVectorView<TextSegment> Find(string content);

    /// <summary>Returns segments of a source string that match the SemanticTextQuery object's query over properties.</summary>
    /// <param name="propertyContent">A source string to be queried.</param>
    /// <param name="propertyName">The name of the property.</param>
    /// <returns>A collection of TextSegment structures that represent hits from the query.</returns>
    [MethodImpl]
    public extern IVectorView<TextSegment> FindInProperty(
      string propertyContent,
      string propertyName);
  }
}
