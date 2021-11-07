// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.CodecQuery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides the FindAllAsync method which allows you to enumerate all media codecs installed on the system.</summary>
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772163)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class CodecQuery : ICodecQuery
  {
    /// <summary>Initializes a new instance of the **CodecQuery** class.</summary>
    [MethodImpl]
    public extern CodecQuery();

    /// <summary>Returns a read-only list of all media codecs installed on the system that meet the specified requirements.</summary>
    /// <param name="kind">A value that specifies whether the method should return codecs that operate on video or audio data.</param>
    /// <param name="category">A value that specifies whether the method should return codecs that are encoders or decoders.</param>
    /// <param name="subType">A value specifying the media encoding subtype that all returned codecs must support. This value can be a string representation of one of the subtype GUIDs listed in Audio Subtype GUIDs or Video Subtyp GUIDs. The CodecSubtypes class provides properties for most supported media subtypes that return the string representation of the subtype GUID. You can also specify a FOURCC code for this parameter. For more information, see FOURCC Codes.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<CodecInfo>> FindAllAsync(
      CodecKind kind,
      CodecCategory category,
      string subType);
  }
}
