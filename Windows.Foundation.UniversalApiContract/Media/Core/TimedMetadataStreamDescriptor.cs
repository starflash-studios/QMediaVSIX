// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedMetadataStreamDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  /// <summary>Represents a description a timed metada media stream.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ITimedMetadataStreamDescriptorFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  public sealed class TimedMetadataStreamDescriptor : 
    ITimedMetadataStreamDescriptor,
    IMediaStreamDescriptor2,
    IMediaStreamDescriptor
  {
    /// <summary>Creates an instance of the TimedMetadataStreamDescriptor class using the specified TimedMetadataEncodingProperties.</summary>
    /// <param name="encodingProperties">The encoding properties for the timed metadata stream.</param>
    [MethodImpl]
    public extern TimedMetadataStreamDescriptor(TimedMetadataEncodingProperties encodingProperties);

    /// <summary>Gets an object describing the encoding properties for the timed metadata stream.</summary>
    /// <returns>The encoding properties on the timed metadata stream.</returns>
    public extern TimedMetadataEncodingProperties EncodingProperties { [MethodImpl] get; }

    /// <summary>Creates a copy of the TimedMetadataStreamDescriptor.</summary>
    /// <returns>A copy of the TimedMetadataStreamDescriptor.</returns>
    [MethodImpl]
    public extern TimedMetadataStreamDescriptor Copy();

    /// <summary>Gets or sets an app-defined label that identifies a timed metadata stream in a MediaEncodingProfile that contains multiple streams.</summary>
    /// <returns>An app-defined label that identifies a timed metadata stream.</returns>
    public extern string Label { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets a value indicating whether the stream is currently in use by a MediaStreamSource.</summary>
    /// <returns>**true** if the stream is currently in use by a MediaStreamSource; otherwise, **false**.</returns>
    public extern bool IsSelected { [MethodImpl] get; }

    /// <summary>Gets or sets the name of the stream.</summary>
    /// <returns>The name of the stream.</returns>
    public extern string Name { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the RFC-1766 language code for the stream.</summary>
    /// <returns>The RFC-1766 language code for the stream.</returns>
    public extern string Language { [MethodImpl] set; [MethodImpl] get; }
  }
}
