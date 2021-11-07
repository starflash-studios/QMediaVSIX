// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyITADataGenerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Creates the PlayReady ITA-specific serialized initialization data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlayReadyITADataGenerator : IPlayReadyITADataGenerator
  {
    /// <summary>Initializes a new instance of the PlayReadyITADataGenerator class.</summary>
    [MethodImpl]
    public extern PlayReadyITADataGenerator();

    /// <summary>Returns a serialized blob of the specified IPropertySet data that the PlayReady ITA can consume if wrapped in a content protection instantiation format.</summary>
    /// <param name="guidCPSystemId">The content protection system **GUID**.</param>
    /// <param name="countOfStreams">The stream count.</param>
    /// <param name="configuration">The data to be returned as a serialized blob.</param>
    /// <param name="format">The format for the ITA serialized data.</param>
    /// <returns>The serialized blob. See Remarks.</returns>
    [MethodImpl]
    public extern byte[] GenerateData(
      Guid guidCPSystemId,
      uint countOfStreams,
      IPropertySet configuration,
      PlayReadyITADataFormat format);
  }
}
