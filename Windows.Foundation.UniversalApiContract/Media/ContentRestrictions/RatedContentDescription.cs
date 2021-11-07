// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.RatedContentDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.ContentRestrictions
{
  /// <summary>Contains information about a piece of content. An app creates a **RatedContentDescription** object, for each piece of content to be used in the GetRestrictionLevelAsync and RequestContentAccessAsync methods.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IRatedContentDescriptionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RatedContentDescription : IRatedContentDescription
  {
    /// <summary>Initializes a new instance of the **RatedContentDescription** class.</summary>
    /// <param name="id">The ID of the content, as specified by the app developer.</param>
    /// <param name="title">The title of the content.</param>
    /// <param name="category">Specifies the type of a piece of content, defined by RatedContentCategory.</param>
    [MethodImpl]
    public extern RatedContentDescription(string id, string title, RatedContentCategory category);

    /// <summary>The unique content ID of a piece of content, in the app's content catalog.</summary>
    /// <returns>The ID of the content as a string.</returns>
    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The display title of a piece of content.</summary>
    /// <returns>The title of the content as a string. Read/Write.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The thumbnail image associated with the content.</summary>
    /// <returns>An image associated with the content.</returns>
    public extern IRandomAccessStreamReference Image { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the type of a piece of content, defined by RatedContentCategory.</summary>
    /// <returns>Specifies the type of a piece of content, defined by RatedContentCategory.</returns>
    public extern RatedContentCategory Category { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Provides all existing third-party and Microsoft Store age ratings for a piece of content.</summary>
    /// <returns>Specifies the age rating, for a piece of content.</returns>
    public extern IVector<string> Ratings { [MethodImpl] get; [MethodImpl] set; }
  }
}
