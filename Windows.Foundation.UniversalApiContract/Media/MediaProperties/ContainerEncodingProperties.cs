// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.ContainerEncodingProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  /// <summary>Describes a media container format.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContainerEncodingProperties : 
    IContainerEncodingProperties,
    IMediaEncodingProperties,
    IContainerEncodingProperties2
  {
    /// <summary>Creates a new instance of the ContainerEncodingProperties class.</summary>
    [MethodImpl]
    public extern ContainerEncodingProperties();

    /// <summary>Gets additional format properties for the media container.</summary>
    /// <returns>A property set that contains format properties.</returns>
    public extern MediaPropertySet Properties { [MethodImpl] get; }

    /// <summary>Gets the format type.</summary>
    /// <returns>The format type. For media containers, the format type is "Container".</returns>
    public extern string Type { [MethodImpl] get; }

    /// <summary>Gets or sets the subtype of the media container.</summary>
    /// <returns>The subtype.</returns>
    public extern string Subtype { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Creates a copy of the **ContainerEncodingProperties** object.</summary>
    /// <returns>A copy of the **ContainerEncodingProperties** object.</returns>
    [MethodImpl]
    public extern ContainerEncodingProperties Copy();
  }
}
