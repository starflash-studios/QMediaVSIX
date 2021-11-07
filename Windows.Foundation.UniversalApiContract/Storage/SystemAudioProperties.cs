// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemAudioProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  /// <summary>A helper object that provides indexing names for Windows audio file properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SystemAudioProperties : ISystemAudioProperties
  {
    /// <summary>Gets the name of the System.Audio.EncodingBitrate property (one of the Windows audio file properties ).</summary>
    /// <returns>The name of the System.Audio.EncodingBitrate property.</returns>
    public extern string EncodingBitrate { [MethodImpl] get; }
  }
}
