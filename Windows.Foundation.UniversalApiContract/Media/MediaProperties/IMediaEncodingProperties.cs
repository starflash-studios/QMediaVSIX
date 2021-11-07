// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IMediaEncodingProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Describes the format of a media stream or media container.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3019909878, 44244, 20058, 162, 75, 93, 116, 152, 168, 184, 196)]
  public interface IMediaEncodingProperties
  {
    /// <summary>Gets additional format properties.</summary>
    /// <returns>A property set that contains format properties.</returns>
    MediaPropertySet Properties { get; }

    /// <summary>Gets the format type.</summary>
    /// <returns>The format type. The value can be the string representation of a GUID in canonical form, or one of the predefined values listed in the following table.&lt;table&gt;</returns>
    string Type { get; }

    /// <summary>Gets or sets the subtype of the format.</summary>
    /// <returns>The subtype.</returns>
    string Subtype { set; get; }
  }
}
