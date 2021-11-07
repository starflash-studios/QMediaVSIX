// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.TimedMetadataEncodingProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Describes the encoding properties of a timed metadata stream. Timed metadata streams are used to encode data that is neither audio or video. For example, a media file may contain a video stream and a timed metadata stream containing GPS coordinates correlated to the video.</summary>
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITimedMetadataEncodingPropertiesStatics), 655360, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class TimedMetadataEncodingProperties : 
    ITimedMetadataEncodingProperties,
    IMediaEncodingProperties
  {
    /// <summary>Creates a new instance of the TimedMetadataEncodingProperties class.</summary>
    [MethodImpl]
    public extern TimedMetadataEncodingProperties();

    /// <summary>Sets information about the metadata encoding that is specific to the format type.</summary>
    /// <param name="value">A byte array containing format-specific encoding information.</param>
    [MethodImpl]
    public extern void SetFormatUserData(byte[] value);

    /// <summary>Gets information about the metadata encoding that is specific to the format type.</summary>
    /// <param name="value">A byte array containing format-specific encoding information.</param>
    [MethodImpl]
    public extern void GetFormatUserData(out byte[] value);

    /// <summary>Creates a copy of the **TimedMetadataEncodingProperties** object.</summary>
    /// <returns>A copy of the **TimedMetadataEncodingProperties** object.</returns>
    [MethodImpl]
    public extern TimedMetadataEncodingProperties Copy();

    /// <summary>Gets additional format properties for the timed metadata stream.</summary>
    /// <returns>A property set that contains format properties.</returns>
    public extern MediaPropertySet Properties { [MethodImpl] get; }

    /// <summary>Gets a string specifying the format type of the typed metadata.</summary>
    /// <returns>A string specifying the format type of the typed metadata.</returns>
    public extern string Type { [MethodImpl] get; }

    /// <summary>Gets a string specifying the format subtype of the typed metadata.</summary>
    /// <returns>A string specifying the format subtype of the typed metadata.</returns>
    public extern string Subtype { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Creates an instance of TimedMetadataEncodingProperties for the Presentation Graphic Stream (PGS) format.</summary>
    /// <returns>The timed text encoding properties.</returns>
    [MethodImpl]
    public static extern TimedMetadataEncodingProperties CreatePgs();

    /// <summary>Creates an instance of TimedMetadataEncodingProperties for the SubRip Text (SRT) format.</summary>
    /// <returns>The timed text encoding properties.</returns>
    [MethodImpl]
    public static extern TimedMetadataEncodingProperties CreateSrt();

    /// <summary>Creates an instance of TimedMetadataEncodingProperties for the SubStation Alpha Text (SSA) format.</summary>
    /// <param name="formatUserData">Format-defined user data.  For more information, see SubstationAlpha.</param>
    /// <returns>The timed text encoding properties.</returns>
    [MethodImpl]
    public static extern TimedMetadataEncodingProperties CreateSsa(
      byte[] formatUserData);

    /// <summary>Creates an instance of TimedMetadataEncodingProperties for the VobSub format.</summary>
    /// <param name="formatUserData">Format-defined user data. For more information, see DirectVobSub.</param>
    /// <returns>The timed text encoding properties.</returns>
    [MethodImpl]
    public static extern TimedMetadataEncodingProperties CreateVobSub(
      byte[] formatUserData);
  }
}
