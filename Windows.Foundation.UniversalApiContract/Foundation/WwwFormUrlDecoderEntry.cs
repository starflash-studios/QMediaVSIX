// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.WwwFormUrlDecoderEntry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a name-value pair in a URL query string. Use the IWwwFormUrlDecoderEntry interface instead; see Remarks.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class WwwFormUrlDecoderEntry : IWwwFormUrlDecoderEntry
  {
    /// <summary>Represents the name of a parameter in a URL query string. Use the IWwwFormUrlDecoderEntry interface version (IWwwFormUrlDecoderEntry.Name ) instead; see Remarks.</summary>
    /// <returns>The name of a query string parameter. The Value property represents the corresponding value.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Represents a named value in a URL query string. Use the IWwwFormUrlDecoderEntry interface version (IWwwFormUrlDecoderEntry.Value ) instead; see Remarks.</summary>
    /// <returns>The value of a query parameter that corresponds with the Name property.</returns>
    public extern string Value { [MethodImpl] get; }
  }
}
