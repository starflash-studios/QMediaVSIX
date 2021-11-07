// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataProviderRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>An object of this type is passed to the DataProviderHandler delegate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DataProviderRequest : IDataProviderRequest
  {
    /// <summary>Specifies the format id.</summary>
    /// <returns>The format id. See StandardDataFormats for more information.</returns>
    public extern string FormatId { [MethodImpl] get; }

    /// <summary>Gets the deadline for finishing a delayed rendering operation. If execution goes beyond that deadline, the results of delayed rendering are ignored.</summary>
    /// <returns>The deadline for the delayed rendering operation.</returns>
    public extern DateTime Deadline { [MethodImpl] get; }

    /// <summary>Returns a DataProviderDeferral object.</summary>
    /// <returns>An data provider deferral object.</returns>
    [MethodImpl]
    public extern DataProviderDeferral GetDeferral();

    /// <summary>Sets the content of the DataPackage to be shared with a target app.</summary>
    /// <param name="value">The object associated with a particular format in the DataPackage.</param>
    [MethodImpl]
    public extern void SetData([HasVariant] object value);
  }
}
